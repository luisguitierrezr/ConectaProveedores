using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionAccountingRequisitionFile2Record
public class RESTRC_38cfa4b424b01ab9c089e700fede9b7d : AbstractRESTStructure<RC_38cfa4b424b01ab9c089e700fede9b7d> {
[JsonProperty("RequisitionAccounting")]
public ssConectaProveedores.RestRecords.RESTEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord AttrRequisitionAccounting;

[JsonProperty("RequisitionFile2")]
public ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord AttrRequisitionFile2;

public RESTRC_38cfa4b424b01ab9c089e700fede9b7d() { }

public RESTRC_38cfa4b424b01ab9c089e700fede9b7d (RC_38cfa4b424b01ab9c089e700fede9b7d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionAccounting = ConvertToRestWithoutDefaults(s.ssENRequisitionAccounting, new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.FromStructure, config);
AttrRequisitionFile2 = ConvertToRestWithoutDefaults(s.ssENRequisitionFile2, new EN_4cce425e15647f937e21de4e52849889EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure, config);
  } else {
AttrRequisitionAccounting = ssConectaProveedores.RestRecords.RESTEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.FromStructure(s.ssENRequisitionAccounting, config);
AttrRequisitionFile2 = ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.FromStructure(s.ssENRequisitionFile2, config);
  }
}

public static RC_38cfa4b424b01ab9c089e700fede9b7d ToStructure(ssConectaProveedores.RestRecords.RESTRC_38cfa4b424b01ab9c089e700fede9b7d obj) { 
  RC_38cfa4b424b01ab9c089e700fede9b7d s = new RC_38cfa4b424b01ab9c089e700fede9b7d();
  if(obj != null) {
  s.ssENRequisitionAccounting = ssConectaProveedores.RestRecords.RESTEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.ToStructure(obj.AttrRequisitionAccounting);
  s.ssENRequisitionFile2 = ssConectaProveedores.RestRecords.RESTEN_4cce425e15647f937e21de4e52849889EntityRecord.ToStructure(obj.AttrRequisitionFile2);
  }
  return s;
}

public static Func<RC_38cfa4b424b01ab9c089e700fede9b7d, ssConectaProveedores.RestRecords.RESTRC_38cfa4b424b01ab9c089e700fede9b7d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_38cfa4b424b01ab9c089e700fede9b7d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_38cfa4b424b01ab9c089e700fede9b7d FromStructure(RC_38cfa4b424b01ab9c089e700fede9b7d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_38cfa4b424b01ab9c089e700fede9b7d(s, config);
}

}


