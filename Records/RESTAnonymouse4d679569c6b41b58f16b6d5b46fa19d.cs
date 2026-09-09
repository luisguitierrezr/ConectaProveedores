using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoicesReport48_FiltersRecord
public class RESTRC_dfad9538363a231d39994ccbe485157c : AbstractRESTStructure<RC_dfad9538363a231d39994ccbe485157c> {
[JsonProperty("InvoicesReport48_Filters")]
public ssConectaProveedores.RestRecords.RESTST_4301e782f48f03168dfeb78159c19548Structure AttrInvoicesReport48_Filters;

public RESTRC_dfad9538363a231d39994ccbe485157c() { }

public RESTRC_dfad9538363a231d39994ccbe485157c (RC_dfad9538363a231d39994ccbe485157c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoicesReport48_Filters = ConvertToRestWithoutDefaults(s.ssSTInvoicesReport48_Filters, new ST_4301e782f48f03168dfeb78159c19548Structure(), ssConectaProveedores.RestRecords.RESTST_4301e782f48f03168dfeb78159c19548Structure.FromStructure, config);
  } else {
AttrInvoicesReport48_Filters = ssConectaProveedores.RestRecords.RESTST_4301e782f48f03168dfeb78159c19548Structure.FromStructure(s.ssSTInvoicesReport48_Filters, config);
  }
}

public static RC_dfad9538363a231d39994ccbe485157c ToStructure(ssConectaProveedores.RestRecords.RESTRC_dfad9538363a231d39994ccbe485157c obj) { 
  RC_dfad9538363a231d39994ccbe485157c s = new RC_dfad9538363a231d39994ccbe485157c();
  if(obj != null) {
  s.ssSTInvoicesReport48_Filters = ssConectaProveedores.RestRecords.RESTST_4301e782f48f03168dfeb78159c19548Structure.ToStructure(obj.AttrInvoicesReport48_Filters);
  }
  return s;
}

public static Func<RC_dfad9538363a231d39994ccbe485157c, ssConectaProveedores.RestRecords.RESTRC_dfad9538363a231d39994ccbe485157c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_dfad9538363a231d39994ccbe485157c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_dfad9538363a231d39994ccbe485157c FromStructure(RC_dfad9538363a231d39994ccbe485157c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_dfad9538363a231d39994ccbe485157c(s, config);
}

}


