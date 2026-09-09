using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionAccountingRequisitionFile2Record
public class JSONRC_38cfa4b424b01ab9c089e700fede9b7d : AbstractRESTStructure<RC_38cfa4b424b01ab9c089e700fede9b7d> {
[JsonProperty("RequisitionAccounting")]
[JsonPropertyName("RequisitionAccounting")]
public ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord AttrRequisitionAccounting;

[JsonProperty("RequisitionFile2")]
[JsonPropertyName("RequisitionFile2")]
public ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord AttrRequisitionFile2;

public JSONRC_38cfa4b424b01ab9c089e700fede9b7d() { }

public JSONRC_38cfa4b424b01ab9c089e700fede9b7d (RC_38cfa4b424b01ab9c089e700fede9b7d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionAccounting = ConvertToRestWithoutDefaults(s.ssENRequisitionAccounting, new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.FromStructure, config);
AttrRequisitionFile2 = ConvertToRestWithoutDefaults(s.ssENRequisitionFile2, new EN_4cce425e15647f937e21de4e52849889EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure, config);
  } else {
AttrRequisitionAccounting = ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.FromStructure(s.ssENRequisitionAccounting, config);
AttrRequisitionFile2 = ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure(s.ssENRequisitionFile2, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_38cfa4b424b01ab9c089e700fede9b7d, RC_38cfa4b424b01ab9c089e700fede9b7d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_38cfa4b424b01ab9c089e700fede9b7d s) => ToStructure(s, config);
}
public static RC_38cfa4b424b01ab9c089e700fede9b7d ToStructure(ssConectaProveedores.RestRecords.JSONRC_38cfa4b424b01ab9c089e700fede9b7d obj, IBehaviorsConfiguration config) { 
  RC_38cfa4b424b01ab9c089e700fede9b7d s = new RC_38cfa4b424b01ab9c089e700fede9b7d();
  if(obj != null) {
  s.ssENRequisitionAccounting = ssConectaProveedores.RestRecords.JSONEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.ToStructure(obj.AttrRequisitionAccounting, config);
  s.ssENRequisitionFile2 = ssConectaProveedores.RestRecords.JSONEN_4cce425e15647f937e21de4e52849889EntityRecord.ToStructure(obj.AttrRequisitionFile2, config);
  }
  return s;
}

public static Func<RC_38cfa4b424b01ab9c089e700fede9b7d, ssConectaProveedores.RestRecords.JSONRC_38cfa4b424b01ab9c089e700fede9b7d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_38cfa4b424b01ab9c089e700fede9b7d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_38cfa4b424b01ab9c089e700fede9b7d FromStructure(RC_38cfa4b424b01ab9c089e700fede9b7d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_38cfa4b424b01ab9c089e700fede9b7d(s, config);
}

}


