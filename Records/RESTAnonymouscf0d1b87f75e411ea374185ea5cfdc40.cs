using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainItemInvoiceUsageRecord
public class RESTRC_d2afc71b0d41323d7c4b380eedf435e1 : AbstractRESTStructure<RC_d2afc71b0d41323d7c4b380eedf435e1> {
[JsonProperty("OrderMainItem")]
public ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord AttrOrderMainItem;

[JsonProperty("InvoiceUsage")]
public ssConectaProveedores.RestRecords.RESTEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord AttrInvoiceUsage;

public RESTRC_d2afc71b0d41323d7c4b380eedf435e1() { }

public RESTRC_d2afc71b0d41323d7c4b380eedf435e1 (RC_d2afc71b0d41323d7c4b380eedf435e1 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMainItem = ConvertToRestWithoutDefaults(s.ssENOrderMainItem, new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure, config);
AttrInvoiceUsage = ConvertToRestWithoutDefaults(s.ssENInvoiceUsage, new EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord.FromStructure, config);
  } else {
AttrOrderMainItem = ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure(s.ssENOrderMainItem, config);
AttrInvoiceUsage = ssConectaProveedores.RestRecords.RESTEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord.FromStructure(s.ssENInvoiceUsage, config);
  }
}

public static RC_d2afc71b0d41323d7c4b380eedf435e1 ToStructure(ssConectaProveedores.RestRecords.RESTRC_d2afc71b0d41323d7c4b380eedf435e1 obj) { 
  RC_d2afc71b0d41323d7c4b380eedf435e1 s = new RC_d2afc71b0d41323d7c4b380eedf435e1();
  if(obj != null) {
  s.ssENOrderMainItem = ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.ToStructure(obj.AttrOrderMainItem);
  s.ssENInvoiceUsage = ssConectaProveedores.RestRecords.RESTEN_4b4c014d751d32313a045df1c34bbf8fEntityRecord.ToStructure(obj.AttrInvoiceUsage);
  }
  return s;
}

public static Func<RC_d2afc71b0d41323d7c4b380eedf435e1, ssConectaProveedores.RestRecords.RESTRC_d2afc71b0d41323d7c4b380eedf435e1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d2afc71b0d41323d7c4b380eedf435e1 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d2afc71b0d41323d7c4b380eedf435e1 FromStructure(RC_d2afc71b0d41323d7c4b380eedf435e1 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d2afc71b0d41323d7c4b380eedf435e1(s, config);
}

}


