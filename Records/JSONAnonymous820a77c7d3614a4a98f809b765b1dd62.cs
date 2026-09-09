using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SpecialWorkflowUploadPuestosRecord
public class JSONRC_46f699009338b3c2298787ee4b6262ec : AbstractRESTStructure<RC_46f699009338b3c2298787ee4b6262ec> {
[JsonProperty("SpecialWorkflowUploadPuestos")]
[JsonPropertyName("SpecialWorkflowUploadPuestos")]
public ssConectaProveedores.RestRecords.JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord AttrSpecialWorkflowUploadPuestos;

public JSONRC_46f699009338b3c2298787ee4b6262ec() { }

public JSONRC_46f699009338b3c2298787ee4b6262ec (RC_46f699009338b3c2298787ee4b6262ec s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSpecialWorkflowUploadPuestos = ConvertToRestWithoutDefaults(s.ssENSpecialWorkflowUploadPuestos, new EN_6cd53511aabe58e5fca112b15ac56b29EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord.FromStructure, config);
  } else {
AttrSpecialWorkflowUploadPuestos = ssConectaProveedores.RestRecords.JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord.FromStructure(s.ssENSpecialWorkflowUploadPuestos, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_46f699009338b3c2298787ee4b6262ec, RC_46f699009338b3c2298787ee4b6262ec> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_46f699009338b3c2298787ee4b6262ec s) => ToStructure(s, config);
}
public static RC_46f699009338b3c2298787ee4b6262ec ToStructure(ssConectaProveedores.RestRecords.JSONRC_46f699009338b3c2298787ee4b6262ec obj, IBehaviorsConfiguration config) { 
  RC_46f699009338b3c2298787ee4b6262ec s = new RC_46f699009338b3c2298787ee4b6262ec();
  if(obj != null) {
  s.ssENSpecialWorkflowUploadPuestos = ssConectaProveedores.RestRecords.JSONEN_6cd53511aabe58e5fca112b15ac56b29EntityRecord.ToStructure(obj.AttrSpecialWorkflowUploadPuestos, config);
  }
  return s;
}

public static Func<RC_46f699009338b3c2298787ee4b6262ec, ssConectaProveedores.RestRecords.JSONRC_46f699009338b3c2298787ee4b6262ec> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_46f699009338b3c2298787ee4b6262ec s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_46f699009338b3c2298787ee4b6262ec FromStructure(RC_46f699009338b3c2298787ee4b6262ec s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_46f699009338b3c2298787ee4b6262ec(s, config);
}

}


