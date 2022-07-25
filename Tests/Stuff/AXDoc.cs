namespace Tests.Stuff
{
    [ACUtils.AXRepository.Attributes.AxClass(document_type: "DEV.TEST", description:"Documento di test", stato:"TEST")]
    public class AXDoc: ACUtils.AXRepository.AXModel<AXDoc>
    {

        [ACUtils.AXRepository.Attributes.AxField(ax_field: "DOCNUMBER", key: 1)]
        public override int? DOCNUMBER { get; set; }

        [ACUtils.AXRepository.Attributes.AxField(ax_field:"TESTO16_5")]
        public string Prova { get; set; }
    }
}
