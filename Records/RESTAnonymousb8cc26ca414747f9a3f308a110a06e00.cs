using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedRelationsRecord
public class RESTRC_759c053ad9cffaec26c59da8e40042d4 : AbstractRESTStructure<RC_759c053ad9cffaec26c59da8e40042d4> {
[JsonProperty("InvoiceExtendedRelations")]
public ssConectaProveedores.RestRecords.RESTEN_bed0bd9c669d37b78ff62c10256a383cEntityRecord AttrInvoiceExtendedRelations;

public RESTRC_759c053ad9cffaec26c59da8e40042d4() { }

public RESTRC_759c053ad9cffaec26c59da8e40042d4 (RC_759c053ad9cffaec26c59da8e40042d4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtendedRelations = ConvertToRestWithoutDefaults(s.ssENInvoiceExtendedRelations, new EN_bed0bd9c669d37b78ff62c10256a383cEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_bed0bd9c669d37b78ff62c10256a383cEntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtendedRelations = ssConectaProveedores.RestRecords.RESTEN_bed0bd9c669d37b78ff62c10256a383cEntityRecord.FromStructure(s.ssENInvoiceExtendedRelations, config);
  }
}

public static RC_759c053ad9cffaec26c59da8e40042d4 ToStructure(ssConectaProveedores.RestRecords.RESTRC_759c053ad9cffaec26c59da8e40042d4 obj) { 
  RC_759c053ad9cffaec26c59da8e40042d4 s = new RC_759c053ad9cffaec26c59da8e40042d4();
  if(obj != null) {
  s.ssENInvoiceExtendedRelations = ssConectaProveedores.RestRecords.RESTEN_bed0bd9c669d37b78ff62c10256a383cEntityRecord.ToStructure(obj.AttrInvoiceExtendedRelations);
  }
  return s;
}

public static Func<RC_759c053ad9cffaec26c59da8e40042d4, ssConectaProveedores.RestRecords.RESTRC_759c053ad9cffaec26c59da8e40042d4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_759c053ad9cffaec26c59da8e40042d4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_759c053ad9cffaec26c59da8e40042d4 FromStructure(RC_759c053ad9cffaec26c59da8e40042d4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_759c053ad9cffaec26c59da8e40042d4(s, config);
}

}


