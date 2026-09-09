using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ExportDisplayedProposalsStructRecord
public class JSONRC_1cb14075fc17c6595e88321dd320acf3 : AbstractRESTStructure<RC_1cb14075fc17c6595e88321dd320acf3> {
[JsonProperty("ExportDisplayedProposalsStruct")]
[JsonPropertyName("ExportDisplayedProposalsStruct")]
public ssConectaProveedores.RestRecords.JSONST_1c87550db65690e27fa2476539c804c3Structure AttrExportDisplayedProposalsStruct;

public JSONRC_1cb14075fc17c6595e88321dd320acf3() { }

public JSONRC_1cb14075fc17c6595e88321dd320acf3 (RC_1cb14075fc17c6595e88321dd320acf3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrExportDisplayedProposalsStruct = ConvertToRestWithoutDefaults(s.ssSTExportDisplayedProposalsStruct, new ST_1c87550db65690e27fa2476539c804c3Structure(), ssConectaProveedores.RestRecords.JSONST_1c87550db65690e27fa2476539c804c3Structure.FromStructure, config);
  } else {
AttrExportDisplayedProposalsStruct = ssConectaProveedores.RestRecords.JSONST_1c87550db65690e27fa2476539c804c3Structure.FromStructure(s.ssSTExportDisplayedProposalsStruct, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1cb14075fc17c6595e88321dd320acf3, RC_1cb14075fc17c6595e88321dd320acf3> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1cb14075fc17c6595e88321dd320acf3 s) => ToStructure(s, config);
}
public static RC_1cb14075fc17c6595e88321dd320acf3 ToStructure(ssConectaProveedores.RestRecords.JSONRC_1cb14075fc17c6595e88321dd320acf3 obj, IBehaviorsConfiguration config) { 
  RC_1cb14075fc17c6595e88321dd320acf3 s = new RC_1cb14075fc17c6595e88321dd320acf3();
  if(obj != null) {
  s.ssSTExportDisplayedProposalsStruct = ssConectaProveedores.RestRecords.JSONST_1c87550db65690e27fa2476539c804c3Structure.ToStructure(obj.AttrExportDisplayedProposalsStruct, config);
  }
  return s;
}

public static Func<RC_1cb14075fc17c6595e88321dd320acf3, ssConectaProveedores.RestRecords.JSONRC_1cb14075fc17c6595e88321dd320acf3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1cb14075fc17c6595e88321dd320acf3 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1cb14075fc17c6595e88321dd320acf3 FromStructure(RC_1cb14075fc17c6595e88321dd320acf3 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1cb14075fc17c6595e88321dd320acf3(s, config);
}

}


