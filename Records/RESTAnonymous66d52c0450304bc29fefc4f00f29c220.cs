using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExportDisplayedProposalsStructRecord
public class RESTRC_1cb14075fc17c6595e88321dd320acf3 : AbstractRESTStructure<RC_1cb14075fc17c6595e88321dd320acf3> {
[JsonProperty("ExportDisplayedProposalsStruct")]
public ssConectaProveedores.RestRecords.RESTST_1c87550db65690e27fa2476539c804c3Structure AttrExportDisplayedProposalsStruct;

public RESTRC_1cb14075fc17c6595e88321dd320acf3() { }

public RESTRC_1cb14075fc17c6595e88321dd320acf3 (RC_1cb14075fc17c6595e88321dd320acf3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrExportDisplayedProposalsStruct = ConvertToRestWithoutDefaults(s.ssSTExportDisplayedProposalsStruct, new ST_1c87550db65690e27fa2476539c804c3Structure(), ssConectaProveedores.RestRecords.RESTST_1c87550db65690e27fa2476539c804c3Structure.FromStructure, config);
  } else {
AttrExportDisplayedProposalsStruct = ssConectaProveedores.RestRecords.RESTST_1c87550db65690e27fa2476539c804c3Structure.FromStructure(s.ssSTExportDisplayedProposalsStruct, config);
  }
}

public static RC_1cb14075fc17c6595e88321dd320acf3 ToStructure(ssConectaProveedores.RestRecords.RESTRC_1cb14075fc17c6595e88321dd320acf3 obj) { 
  RC_1cb14075fc17c6595e88321dd320acf3 s = new RC_1cb14075fc17c6595e88321dd320acf3();
  if(obj != null) {
  s.ssSTExportDisplayedProposalsStruct = ssConectaProveedores.RestRecords.RESTST_1c87550db65690e27fa2476539c804c3Structure.ToStructure(obj.AttrExportDisplayedProposalsStruct);
  }
  return s;
}

public static Func<RC_1cb14075fc17c6595e88321dd320acf3, ssConectaProveedores.RestRecords.RESTRC_1cb14075fc17c6595e88321dd320acf3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1cb14075fc17c6595e88321dd320acf3 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_1cb14075fc17c6595e88321dd320acf3 FromStructure(RC_1cb14075fc17c6595e88321dd320acf3 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_1cb14075fc17c6595e88321dd320acf3(s, config);
}

}


