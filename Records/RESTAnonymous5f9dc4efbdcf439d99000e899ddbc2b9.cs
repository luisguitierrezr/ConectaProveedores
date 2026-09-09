using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceFilesRecord
public class RESTRC_fcad6692fe9ee374c1913cf07edd9ec9 : AbstractRESTStructure<RC_fcad6692fe9ee374c1913cf07edd9ec9> {
[JsonProperty("InvoiceFiles")]
public ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure AttrInvoiceFiles;

public RESTRC_fcad6692fe9ee374c1913cf07edd9ec9() { }

public RESTRC_fcad6692fe9ee374c1913cf07edd9ec9 (RC_fcad6692fe9ee374c1913cf07edd9ec9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceFiles = ConvertToRestWithoutDefaults(s.ssSTInvoiceFiles, new ST_d381fba44897ce4382b17d5149465d51Structure(), ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure.FromStructure, config);
  } else {
AttrInvoiceFiles = ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure.FromStructure(s.ssSTInvoiceFiles, config);
  }
}

public static RC_fcad6692fe9ee374c1913cf07edd9ec9 ToStructure(ssConectaProveedores.RestRecords.RESTRC_fcad6692fe9ee374c1913cf07edd9ec9 obj) { 
  RC_fcad6692fe9ee374c1913cf07edd9ec9 s = new RC_fcad6692fe9ee374c1913cf07edd9ec9();
  if(obj != null) {
  s.ssSTInvoiceFiles = ssConectaProveedores.RestRecords.RESTST_d381fba44897ce4382b17d5149465d51Structure.ToStructure(obj.AttrInvoiceFiles);
  }
  return s;
}

public static Func<RC_fcad6692fe9ee374c1913cf07edd9ec9, ssConectaProveedores.RestRecords.RESTRC_fcad6692fe9ee374c1913cf07edd9ec9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fcad6692fe9ee374c1913cf07edd9ec9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_fcad6692fe9ee374c1913cf07edd9ec9 FromStructure(RC_fcad6692fe9ee374c1913cf07edd9ec9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_fcad6692fe9ee374c1913cf07edd9ec9(s, config);
}

}


