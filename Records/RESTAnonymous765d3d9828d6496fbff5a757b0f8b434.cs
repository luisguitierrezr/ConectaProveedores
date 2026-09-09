using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoicesUsageAccountsRecord
public class RESTRC_a6177074bb5c56dd37245c971e55737e : AbstractRESTStructure<RC_a6177074bb5c56dd37245c971e55737e> {
[JsonProperty("InvoicesUsageAccounts")]
public ssConectaProveedores.RestRecords.RESTEN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord AttrInvoicesUsageAccounts;

public RESTRC_a6177074bb5c56dd37245c971e55737e() { }

public RESTRC_a6177074bb5c56dd37245c971e55737e (RC_a6177074bb5c56dd37245c971e55737e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoicesUsageAccounts = ConvertToRestWithoutDefaults(s.ssENInvoicesUsageAccounts, new EN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord.FromStructure, config);
  } else {
AttrInvoicesUsageAccounts = ssConectaProveedores.RestRecords.RESTEN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord.FromStructure(s.ssENInvoicesUsageAccounts, config);
  }
}

public static RC_a6177074bb5c56dd37245c971e55737e ToStructure(ssConectaProveedores.RestRecords.RESTRC_a6177074bb5c56dd37245c971e55737e obj) { 
  RC_a6177074bb5c56dd37245c971e55737e s = new RC_a6177074bb5c56dd37245c971e55737e();
  if(obj != null) {
  s.ssENInvoicesUsageAccounts = ssConectaProveedores.RestRecords.RESTEN_55e2bdafa112b0d43651f5fee7b71d60EntityRecord.ToStructure(obj.AttrInvoicesUsageAccounts);
  }
  return s;
}

public static Func<RC_a6177074bb5c56dd37245c971e55737e, ssConectaProveedores.RestRecords.RESTRC_a6177074bb5c56dd37245c971e55737e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a6177074bb5c56dd37245c971e55737e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a6177074bb5c56dd37245c971e55737e FromStructure(RC_a6177074bb5c56dd37245c971e55737e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a6177074bb5c56dd37245c971e55737e(s, config);
}

}


