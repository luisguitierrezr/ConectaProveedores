using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedItemInvoiceExtendedItemTaxListRecord
public class RESTRC_ce1213db14f29aa4f95120ea7ad7d0b7 : AbstractRESTStructure<RC_ce1213db14f29aa4f95120ea7ad7d0b7> {
[JsonProperty("InvoiceExtendedItem")]
public ssConectaProveedores.RestRecords.RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord AttrInvoiceExtendedItem;

[JsonProperty("InvoiceExtendedItemTaxList")]
public RestList<ssConectaProveedores.RestRecords.RESTEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord> AttrInvoiceExtendedItemTaxList;

public RESTRC_ce1213db14f29aa4f95120ea7ad7d0b7() { }

public RESTRC_ce1213db14f29aa4f95120ea7ad7d0b7 (RC_ce1213db14f29aa4f95120ea7ad7d0b7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedItem = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedItem, new EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.FromStructure, config);
AttrInvoiceExtendedItemTaxList = s.ssRLInvoiceExtendedItemTaxList.Length == 0 ? null : s.ssRLInvoiceExtendedItemTaxList.ToRestList<ssConectaProveedores.RestRecords.RESTEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord>(ssConectaProveedores.RestRecords.RESTEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord.FromStructureDelegate(config));
  } else {
AttrInvoiceExtendedItem = ssConectaProveedores.RestRecords.RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.FromStructure(s.ssENInvoiceExtendedItem, config);
AttrInvoiceExtendedItemTaxList = s.ssRLInvoiceExtendedItemTaxList.ToRestList<ssConectaProveedores.RestRecords.RESTEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord>(ssConectaProveedores.RestRecords.RESTEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord.FromStructureDelegate(config));
  }
}

public static RC_ce1213db14f29aa4f95120ea7ad7d0b7 ToStructure(ssConectaProveedores.RestRecords.RESTRC_ce1213db14f29aa4f95120ea7ad7d0b7 obj) { 
  RC_ce1213db14f29aa4f95120ea7ad7d0b7 s = new RC_ce1213db14f29aa4f95120ea7ad7d0b7();
  if(obj != null) {
  s.ssENInvoiceExtendedItem = ssConectaProveedores.RestRecords.RESTEN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord.ToStructure(obj.AttrInvoiceExtendedItem);
  s.ssRLInvoiceExtendedItemTaxList = RL_052a618537841aabfe590fb1dffa78ab.FromRestList(obj.AttrInvoiceExtendedItemTaxList, ssConectaProveedores.RestRecords.RESTEN_ac8f182513b48d814f8a265614e7c7c2EntityRecord.ToStructure);
  }
  return s;
}

public static Func<RC_ce1213db14f29aa4f95120ea7ad7d0b7, ssConectaProveedores.RestRecords.RESTRC_ce1213db14f29aa4f95120ea7ad7d0b7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ce1213db14f29aa4f95120ea7ad7d0b7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ce1213db14f29aa4f95120ea7ad7d0b7 FromStructure(RC_ce1213db14f29aa4f95120ea7ad7d0b7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ce1213db14f29aa4f95120ea7ad7d0b7(s, config);
}

}


