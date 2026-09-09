using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PI_HEADER2Record
public class JSONRC_572f32750027334be4afde2b8efad62f : AbstractRESTStructure<RC_572f32750027334be4afde2b8efad62f> {
[JsonProperty("PI_HEADER2")]
[JsonPropertyName("PI_HEADER2")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_af46d22a4ab690d6a003acf927bb2771Structure AttrPI_HEADER2;

public JSONRC_572f32750027334be4afde2b8efad62f() { }

public JSONRC_572f32750027334be4afde2b8efad62f (RC_572f32750027334be4afde2b8efad62f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER2 = ConvertToRestWithoutDefaults(s.ssSTPI_HEADER2, new ST_af46d22a4ab690d6a003acf927bb2771Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_af46d22a4ab690d6a003acf927bb2771Structure.FromStructure, config);
  } else {
AttrPI_HEADER2 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_af46d22a4ab690d6a003acf927bb2771Structure.FromStructure(s.ssSTPI_HEADER2, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_572f32750027334be4afde2b8efad62f, RC_572f32750027334be4afde2b8efad62f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_572f32750027334be4afde2b8efad62f s) => ToStructure(s, config);
}
public static RC_572f32750027334be4afde2b8efad62f ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_572f32750027334be4afde2b8efad62f obj, IBehaviorsConfiguration config) { 
  RC_572f32750027334be4afde2b8efad62f s = new RC_572f32750027334be4afde2b8efad62f();
  if(obj != null) {
  s.ssSTPI_HEADER2 = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_af46d22a4ab690d6a003acf927bb2771Structure.ToStructure(obj.AttrPI_HEADER2, config);
  }
  return s;
}

public static Func<RC_572f32750027334be4afde2b8efad62f, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_572f32750027334be4afde2b8efad62f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_572f32750027334be4afde2b8efad62f s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_572f32750027334be4afde2b8efad62f FromStructure(RC_572f32750027334be4afde2b8efad62f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_572f32750027334be4afde2b8efad62f(s, config);
}

}


