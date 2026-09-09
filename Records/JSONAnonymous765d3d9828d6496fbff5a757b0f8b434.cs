using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoicesUsageAccountsRecord
public class JSONRC_a6177074bb5c56dd37245c971e55737e : AbstractRESTStructure<RC_a6177074bb5c56dd37245c971e55737e> {
[JsonProperty("InvoicesUsageAccounts")]
[JsonPropertyName("InvoicesUsageAccounts")]
public ssConectaProveedores.RestRecords.JSONEN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord AttrInvoicesUsageAccounts;

public JSONRC_a6177074bb5c56dd37245c971e55737e() { }

public JSONRC_a6177074bb5c56dd37245c971e55737e (RC_a6177074bb5c56dd37245c971e55737e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoicesUsageAccounts = ConvertToRestWithoutDefaults(s.ssENInvoicesUsageAccounts, new EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord.FromStructure, config);
  } else {
AttrInvoicesUsageAccounts = ssConectaProveedores.RestRecords.JSONEN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord.FromStructure(s.ssENInvoicesUsageAccounts, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a6177074bb5c56dd37245c971e55737e, RC_a6177074bb5c56dd37245c971e55737e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a6177074bb5c56dd37245c971e55737e s) => ToStructure(s, config);
}
public static RC_a6177074bb5c56dd37245c971e55737e ToStructure(ssConectaProveedores.RestRecords.JSONRC_a6177074bb5c56dd37245c971e55737e obj, IBehaviorsConfiguration config) { 
  RC_a6177074bb5c56dd37245c971e55737e s = new RC_a6177074bb5c56dd37245c971e55737e();
  if(obj != null) {
  s.ssENInvoicesUsageAccounts = ssConectaProveedores.RestRecords.JSONEN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord.ToStructure(obj.AttrInvoicesUsageAccounts, config);
  }
  return s;
}

public static Func<RC_a6177074bb5c56dd37245c971e55737e, ssConectaProveedores.RestRecords.JSONRC_a6177074bb5c56dd37245c971e55737e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a6177074bb5c56dd37245c971e55737e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a6177074bb5c56dd37245c971e55737e FromStructure(RC_a6177074bb5c56dd37245c971e55737e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a6177074bb5c56dd37245c971e55737e(s, config);
}

}


