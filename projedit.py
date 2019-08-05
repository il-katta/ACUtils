#!/usr/bin/env python3
'''
    setta la versione o incrementa l'ultimo numero di versione ( build version ) nei file .csproj per progetti ".NET Standard"
    o nei file AssemblyInfo nei progetti ".NET Framework"
    usage: 
           projedit.py netstandard path/to/project.csproj [<new version number>]
           projedit.py vbframework path/to/AssemblyInfo.vb [<new version number>]
           projedit.py csframework path/to/AssemblyInfo.cs [<new version number>]

'''
import sys
import re
import fileinput
from xml.etree import ElementTree


def xml_change_value_if_exists(proj, path, value):
    node = proj.find(path)
    if node is None:
        return
    node.text = value


def is_int(str_):
    for n in str_:
        if n not in '1234567890':
            return False
    return True


def increase_version_str(current_version):
    build_n = current_version.split('.')[-1]
    if not build_n.isdigit():
        raise Exception("current build version {} is not a number".format(build_n))
    return '.'.join(current_version.split('.')[:-1]) + '.' + str(int(build_n) + 1)


def netstandard_set_version(proj, path, new_version=None):
    node = proj.find(path)
    if node is None:
        return
    if new_version is None:
        current_version = node.text
        new_version = increase_version_str(current_version)
    xml_change_value_if_exists(proj, path, new_version)
    return new_version


def find_and_replace(file_name, regexp, new_version=None):
    re_assembly_file = re.compile(regexp)
    with fileinput.FileInput(file_name, inplace=True, backup='.bak') as file:
        for line in file:
            if re_assembly_file.match(line):
                current_version = re_assembly_file.findall(line).pop()
                if new_version is None:
                    new_version = increase_version_str(current_version)
                print(line.replace(current_version, new_version), end='')
            else:
                print(line, end='')
    return new_version


def netstandard_main(file_name, new_version=None):
    proj = ElementTree.parse(file_name)
    version = None
    try:
        version = netstandard_set_version(proj, 'PropertyGroup/Version', new_version)
    except Exception as e:
        print(str(e))

    try:
        new_version = netstandard_set_version(proj, 'PropertyGroup/PackageVersion', new_version)
        if new_version:
            version = new_version
    except Exception as e:
        print(str(e))

    if version is None:
        print("no changes")
        sys.exit(1)

    proj.write(file_name)
    print(version, end='')


def vbframework_main(file_name, new_version=None):
    new_version = find_and_replace(file_name, r'^\<Assembly: AssemblyFileVersion\("(.*)"\)\>', new_version)
    if new_version is None:
        print("no changes")
        sys.exit(1)
    print(new_version, end='')

def csframework_main(file_name, new_version=None):
    new_version = find_and_replace(file_name, r'^\[assembly: AssemblyFileVersion\("(.*)"\)]$', new_version)
    if new_version is None:
        print("no changes")
        sys.exit(1)
    print(new_version, end='')

# main
if __name__ == '__main__':
    edit_type = sys.argv[1]
    file_name = sys.argv[2]

    if len(sys.argv) == 4:
        new_version = sys.argv[3]
    else:
        new_version = None

    if edit_type == 'netstandard':
        netstandard_main(file_name, new_version)
    elif edit_type == 'vbframework':
        vbframework_main(file_name, new_version)
    elif edit_type == 'csframework':
        csframework_main(file_name, new_version)
    else:
        sys.exit(255)
