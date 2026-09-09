using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceFilesRecord
public class JSONRC_fcad6692fe9ee374c1913cf07edd9ec9 : AbstractRESTStructure<RC_fcad6692fe9ee374c1913cf07edd9ec9> {
[JsonProperty("InvoiceFiles")]
[JsonPropertyName("InvoiceFiles")]
public ssConectaProveedores.RestRecords.JSONST_d381fba44897ce4382b17d5149465d51Structure AttrInvoiceFiles;

public JSONRC_fcad6692fe9ee374c1913cf07edd9ec9() { }

public JSONRC_fcad6692fe9ee374c1913cf07edd9ec9 (RC_fcad6692fe9ee374c1913cf07edd9ec9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceFiles = ConvertToRestWithoutDefaults(s.ssSTInvoiceFiles, new ST_d381fba44897ce4382b17d5149465d51Structure(), ssConectaProveedores.RestRecords.JSONST_d381fba44897ce4382b17d5149465d51Structure.FromStructure, config);
  } else {
AttrInvoiceFiles = ssConectaProveedores.RestRecords.JSONST_d381fba44897ce4382b17d5149465d51Structure.FromStructure(s.ssSTInvoiceFiles, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_fcad6692fe9ee374c1913cf07edd9ec9, RC_fcad6692fe9ee374c1913cf07edd9ec9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_fcad6692fe9ee374c1913cf07edd9ec9 s) => ToStructure(s, config);
}
public static RC_fcad6692fe9ee374c1913cf07edd9ec9 ToStructure(ssConectaProveedores.RestRecords.JSONRC_fcad6692fe9ee374c1913cf07edd9ec9 obj, IBehaviorsConfiguration config) { 
  RC_fcad6692fe9ee374c1913cf07edd9ec9 s = new RC_fcad6692fe9ee374c1913cf07edd9ec9();
  if(obj != null) {
  s.ssSTInvoiceFiles = ssConectaProveedores.RestRecords.JSONST_d381fba44897ce4382b17d5149465d51Structure.ToStructure(obj.AttrInvoiceFiles, config);
  }
  return s;
}

public static Func<RC_fcad6692fe9ee374c1913cf07edd9ec9, ssConectaProveedores.RestRecords.JSONRC_fcad6692fe9ee374c1913cf07edd9ec9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fcad6692fe9ee374c1913cf07edd9ec9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_fcad6692fe9ee374c1913cf07edd9ec9 FromStructure(RC_fcad6692fe9ee374c1913cf07edd9ec9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_fcad6692fe9ee374c1913cf07edd9ec9(s, config);
}

}


