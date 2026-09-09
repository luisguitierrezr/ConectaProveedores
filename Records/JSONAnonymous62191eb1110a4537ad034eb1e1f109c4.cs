using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceFileRecord
public class JSONRC_18990af86f7169e92b712b468e13b947 : AbstractRESTStructure<RC_18990af86f7169e92b712b468e13b947> {
[JsonProperty("InvoiceFile")]
[JsonPropertyName("InvoiceFile")]
public ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord AttrInvoiceFile;

public JSONRC_18990af86f7169e92b712b468e13b947() { }

public JSONRC_18990af86f7169e92b712b468e13b947 (RC_18990af86f7169e92b712b468e13b947 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceFile = ConvertToRestWithoutDefaults(s.ssENInvoiceFile, new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure, config);
  } else {
AttrInvoiceFile = ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.FromStructure(s.ssENInvoiceFile, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_18990af86f7169e92b712b468e13b947, RC_18990af86f7169e92b712b468e13b947> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_18990af86f7169e92b712b468e13b947 s) => ToStructure(s, config);
}
public static RC_18990af86f7169e92b712b468e13b947 ToStructure(ssConectaProveedores.RestRecords.JSONRC_18990af86f7169e92b712b468e13b947 obj, IBehaviorsConfiguration config) { 
  RC_18990af86f7169e92b712b468e13b947 s = new RC_18990af86f7169e92b712b468e13b947();
  if(obj != null) {
  s.ssENInvoiceFile = ssConectaProveedores.RestRecords.JSONEN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord.ToStructure(obj.AttrInvoiceFile, config);
  }
  return s;
}

public static Func<RC_18990af86f7169e92b712b468e13b947, ssConectaProveedores.RestRecords.JSONRC_18990af86f7169e92b712b468e13b947> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_18990af86f7169e92b712b468e13b947 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_18990af86f7169e92b712b468e13b947 FromStructure(RC_18990af86f7169e92b712b468e13b947 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_18990af86f7169e92b712b468e13b947(s, config);
}

}


