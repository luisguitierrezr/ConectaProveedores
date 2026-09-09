using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedRelationsRecord
public class JSONRC_759c053ad9cffaec26c59da8e40042d4 : AbstractRESTStructure<RC_759c053ad9cffaec26c59da8e40042d4> {
[JsonProperty("InvoiceExtendedRelations")]
[JsonPropertyName("InvoiceExtendedRelations")]
public ssConectaProveedores.RestRecords.JSONEN_bed0bd9c669d37b78ff62c10256a383cEntityRecord AttrInvoiceExtendedRelations;

public JSONRC_759c053ad9cffaec26c59da8e40042d4() { }

public JSONRC_759c053ad9cffaec26c59da8e40042d4 (RC_759c053ad9cffaec26c59da8e40042d4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedRelations = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedRelations, new EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_bed0bd9c669d37b78ff62c10256a383cEntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedRelations = ssConectaProveedores.RestRecords.JSONEN_bed0bd9c669d37b78ff62c10256a383cEntityRecord.FromStructure(s.ssENInvoiceExtendedRelations, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_759c053ad9cffaec26c59da8e40042d4, RC_759c053ad9cffaec26c59da8e40042d4> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_759c053ad9cffaec26c59da8e40042d4 s) => ToStructure(s, config);
}
public static RC_759c053ad9cffaec26c59da8e40042d4 ToStructure(ssConectaProveedores.RestRecords.JSONRC_759c053ad9cffaec26c59da8e40042d4 obj, IBehaviorsConfiguration config) { 
  RC_759c053ad9cffaec26c59da8e40042d4 s = new RC_759c053ad9cffaec26c59da8e40042d4();
  if(obj != null) {
  s.ssENInvoiceExtendedRelations = ssConectaProveedores.RestRecords.JSONEN_bed0bd9c669d37b78ff62c10256a383cEntityRecord.ToStructure(obj.AttrInvoiceExtendedRelations, config);
  }
  return s;
}

public static Func<RC_759c053ad9cffaec26c59da8e40042d4, ssConectaProveedores.RestRecords.JSONRC_759c053ad9cffaec26c59da8e40042d4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_759c053ad9cffaec26c59da8e40042d4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_759c053ad9cffaec26c59da8e40042d4 FromStructure(RC_759c053ad9cffaec26c59da8e40042d4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_759c053ad9cffaec26c59da8e40042d4(s, config);
}

}


