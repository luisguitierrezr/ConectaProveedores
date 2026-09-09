using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoicesScreenTableStructureRecord
public class RESTRC_2e7d78681454c0e1bbb6a38d7fddd8cd : AbstractRESTStructure<RC_2e7d78681454c0e1bbb6a38d7fddd8cd> {
[JsonProperty("InvoicesScreenTableStructure")]
public ssConectaProveedores.RestRecords.RESTST_3c6142d371d14231f5ddee7b64c28681Structure AttrInvoicesScreenTableStructure;

public RESTRC_2e7d78681454c0e1bbb6a38d7fddd8cd() { }

public RESTRC_2e7d78681454c0e1bbb6a38d7fddd8cd (RC_2e7d78681454c0e1bbb6a38d7fddd8cd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoicesScreenTableStructure = ConvertToRestWithoutDefaults(s.ssSTInvoicesScreenTableStructure, new ST_3c6142d371d14231f5ddee7b64c28681Structure(), ssConectaProveedores.RestRecords.RESTST_3c6142d371d14231f5ddee7b64c28681Structure.FromStructure, config);
  } else {
AttrInvoicesScreenTableStructure = ssConectaProveedores.RestRecords.RESTST_3c6142d371d14231f5ddee7b64c28681Structure.FromStructure(s.ssSTInvoicesScreenTableStructure, config);
  }
}

public static RC_2e7d78681454c0e1bbb6a38d7fddd8cd ToStructure(ssConectaProveedores.RestRecords.RESTRC_2e7d78681454c0e1bbb6a38d7fddd8cd obj) { 
  RC_2e7d78681454c0e1bbb6a38d7fddd8cd s = new RC_2e7d78681454c0e1bbb6a38d7fddd8cd();
  if(obj != null) {
  s.ssSTInvoicesScreenTableStructure = ssConectaProveedores.RestRecords.RESTST_3c6142d371d14231f5ddee7b64c28681Structure.ToStructure(obj.AttrInvoicesScreenTableStructure);
  }
  return s;
}

public static Func<RC_2e7d78681454c0e1bbb6a38d7fddd8cd, ssConectaProveedores.RestRecords.RESTRC_2e7d78681454c0e1bbb6a38d7fddd8cd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2e7d78681454c0e1bbb6a38d7fddd8cd s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_2e7d78681454c0e1bbb6a38d7fddd8cd FromStructure(RC_2e7d78681454c0e1bbb6a38d7fddd8cd s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_2e7d78681454c0e1bbb6a38d7fddd8cd(s, config);
}

}


