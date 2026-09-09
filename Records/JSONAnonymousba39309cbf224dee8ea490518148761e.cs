using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM_EMRecord
public class JSONRC_e78705ffe9e8d9058346f81525af4b68 : AbstractRESTStructure<RC_e78705ffe9e8d9058346f81525af4b68> {
[JsonProperty("PI_ITEM_EM")]
[JsonPropertyName("PI_ITEM_EM")]
public ssConectaProveedores.RestRecords.JSONST_4e772ab2be79435889bcf86fc0455824Structure AttrPI_ITEM_EM;

public JSONRC_e78705ffe9e8d9058346f81525af4b68() { }

public JSONRC_e78705ffe9e8d9058346f81525af4b68 (RC_e78705ffe9e8d9058346f81525af4b68 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_ITEM_EM = ConvertToRestWithoutDefaults(s.ssSTPI_ITEM_EM, new ST_4e772ab2be79435889bcf86fc0455824Structure(), ssConectaProveedores.RestRecords.JSONST_4e772ab2be79435889bcf86fc0455824Structure.FromStructure, config);
  } else {
AttrPI_ITEM_EM = ssConectaProveedores.RestRecords.JSONST_4e772ab2be79435889bcf86fc0455824Structure.FromStructure(s.ssSTPI_ITEM_EM, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_e78705ffe9e8d9058346f81525af4b68, RC_e78705ffe9e8d9058346f81525af4b68> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_e78705ffe9e8d9058346f81525af4b68 s) => ToStructure(s, config);
}
public static RC_e78705ffe9e8d9058346f81525af4b68 ToStructure(ssConectaProveedores.RestRecords.JSONRC_e78705ffe9e8d9058346f81525af4b68 obj, IBehaviorsConfiguration config) { 
  RC_e78705ffe9e8d9058346f81525af4b68 s = new RC_e78705ffe9e8d9058346f81525af4b68();
  if(obj != null) {
  s.ssSTPI_ITEM_EM = ssConectaProveedores.RestRecords.JSONST_4e772ab2be79435889bcf86fc0455824Structure.ToStructure(obj.AttrPI_ITEM_EM, config);
  }
  return s;
}

public static Func<RC_e78705ffe9e8d9058346f81525af4b68, ssConectaProveedores.RestRecords.JSONRC_e78705ffe9e8d9058346f81525af4b68> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e78705ffe9e8d9058346f81525af4b68 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_e78705ffe9e8d9058346f81525af4b68 FromStructure(RC_e78705ffe9e8d9058346f81525af4b68 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_e78705ffe9e8d9058346f81525af4b68(s, config);
}

}


