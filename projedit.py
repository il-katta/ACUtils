#!/usr/bin/env python3
'''
    usage: projedit.py path/to/project.csproj
    incrementa l'ultimo numero di versione ( build version )
'''
from xml.etree import ElementTree
import sys


def change_if_exists(proj, path, value):
    node = proj.find(path)
    if node is None:
        return
    node.text = value


def is_int(str_):
    for n in str_:
        if n not in '1234567890':
            return False
    return True


def inc_version_if_exists(proj, path):
    node = proj.find(path)
    if node is None:
        return
    current_version = node.text

    # valore dopo l'ultimo punto
    build_n = current_version.split('.')[-1]

    if not build_n.isdigit():
        raise Exception("current build version {} is not a number".format(build_n))

    new_version = '.'.join(current_version.split('.')[:-1]) + '.' + str(int(build_n) + 1)

    change_if_exists(proj, path, new_version)
    return new_version


file_name = sys.argv[1]

proj = ElementTree.parse(file_name)
version = None
try:
    new_version = inc_version_if_exists(proj, 'PropertyGroup/Version')
    if new_version:
        version = new_version
except Exception as e:
    print(str(e))

try:
    new_version = inc_version_if_exists(proj, 'PropertyGroup/PackageVersion')
    if new_version:
        version = new_version
except Exception as e:
    print(str(e))

if version is None:
    print("no changes")
    sys.exit(1)

proj.write(file_name)
print(version)
