using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_HEADER2Record
public class RESTRC_572f32750027334be4afde2b8efad62f : AbstractRESTStructure<RC_572f32750027334be4afde2b8efad62f> {
[JsonProperty("PI_HEADER2")]
public ssConectaProveedores.RestRecords.RESTST_af46d22a4ab690d6a003acf927bb2771Structure AttrPI_HEADER2;

public RESTRC_572f32750027334be4afde2b8efad62f() { }

public RESTRC_572f32750027334be4afde2b8efad62f (RC_572f32750027334be4afde2b8efad62f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER2 = ConvertToRestWithoutDefaults(s.ssSTPI_HEADER2, new ST_af46d22a4ab690d6a003acf927bb2771Structure(), ssConectaProveedores.RestRecords.RESTST_af46d22a4ab690d6a003acf927bb2771Structure.FromStructure, config);
  } else {
AttrPI_HEADER2 = ssConectaProveedores.RestRecords.RESTST_af46d22a4ab690d6a003acf927bb2771Structure.FromStructure(s.ssSTPI_HEADER2, config);
  }
}

public static RC_572f32750027334be4afde2b8efad62f ToStructure(ssConectaProveedores.RestRecords.RESTRC_572f32750027334be4afde2b8efad62f obj) { 
  RC_572f32750027334be4afde2b8efad62f s = new RC_572f32750027334be4afde2b8efad62f();
  if(obj != null) {
  s.ssSTPI_HEADER2 = ssConectaProveedores.RestRecords.RESTST_af46d22a4ab690d6a003acf927bb2771Structure.ToStructure(obj.AttrPI_HEADER2);
  }
  return s;
}

public static Func<RC_572f32750027334be4afde2b8efad62f, ssConectaProveedores.RestRecords.RESTRC_572f32750027334be4afde2b8efad62f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_572f32750027334be4afde2b8efad62f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_572f32750027334be4afde2b8efad62f FromStructure(RC_572f32750027334be4afde2b8efad62f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_572f32750027334be4afde2b8efad62f(s, config);
}

}


