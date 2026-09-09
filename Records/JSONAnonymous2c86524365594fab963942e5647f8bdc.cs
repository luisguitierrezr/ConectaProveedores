using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoicesScreenTableStructureRecord
public class JSONRC_2e7d78681454c0e1bbb6a38d7fddd8cd : AbstractRESTStructure<RC_2e7d78681454c0e1bbb6a38d7fddd8cd> {
[JsonProperty("InvoicesScreenTableStructure")]
[JsonPropertyName("InvoicesScreenTableStructure")]
public ssConectaProveedores.RestRecords.JSONST_3c6142d371d14231f5ddee7b64c28681Structure AttrInvoicesScreenTableStructure;

public JSONRC_2e7d78681454c0e1bbb6a38d7fddd8cd() { }

public JSONRC_2e7d78681454c0e1bbb6a38d7fddd8cd (RC_2e7d78681454c0e1bbb6a38d7fddd8cd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoicesScreenTableStructure = ConvertToRestWithoutDefaults(s.ssSTInvoicesScreenTableStructure, new ST_3c6142d371d14231f5ddee7b64c28681Structure(), ssConectaProveedores.RestRecords.JSONST_3c6142d371d14231f5ddee7b64c28681Structure.FromStructure, config);
  } else {
AttrInvoicesScreenTableStructure = ssConectaProveedores.RestRecords.JSONST_3c6142d371d14231f5ddee7b64c28681Structure.FromStructure(s.ssSTInvoicesScreenTableStructure, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_2e7d78681454c0e1bbb6a38d7fddd8cd, RC_2e7d78681454c0e1bbb6a38d7fddd8cd> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_2e7d78681454c0e1bbb6a38d7fddd8cd s) => ToStructure(s, config);
}
public static RC_2e7d78681454c0e1bbb6a38d7fddd8cd ToStructure(ssConectaProveedores.RestRecords.JSONRC_2e7d78681454c0e1bbb6a38d7fddd8cd obj, IBehaviorsConfiguration config) { 
  RC_2e7d78681454c0e1bbb6a38d7fddd8cd s = new RC_2e7d78681454c0e1bbb6a38d7fddd8cd();
  if(obj != null) {
  s.ssSTInvoicesScreenTableStructure = ssConectaProveedores.RestRecords.JSONST_3c6142d371d14231f5ddee7b64c28681Structure.ToStructure(obj.AttrInvoicesScreenTableStructure, config);
  }
  return s;
}

public static Func<RC_2e7d78681454c0e1bbb6a38d7fddd8cd, ssConectaProveedores.RestRecords.JSONRC_2e7d78681454c0e1bbb6a38d7fddd8cd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2e7d78681454c0e1bbb6a38d7fddd8cd s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_2e7d78681454c0e1bbb6a38d7fddd8cd FromStructure(RC_2e7d78681454c0e1bbb6a38d7fddd8cd s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_2e7d78681454c0e1bbb6a38d7fddd8cd(s, config);
}

}


