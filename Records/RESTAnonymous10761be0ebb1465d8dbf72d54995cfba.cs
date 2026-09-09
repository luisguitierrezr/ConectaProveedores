using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM_EM3Record
public class RESTRC_8f0936c3c24768761df4a411edbf9176 : AbstractRESTStructure<RC_8f0936c3c24768761df4a411edbf9176> {
[JsonProperty("PI_ITEM_EM3")]
public ssConectaProveedores.RestRecords.RESTST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure AttrPI_ITEM_EM3;

public RESTRC_8f0936c3c24768761df4a411edbf9176() { }

public RESTRC_8f0936c3c24768761df4a411edbf9176 (RC_8f0936c3c24768761df4a411edbf9176 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_ITEM_EM3 = ConvertToRestWithoutDefaults(s.ssSTPI_ITEM_EM3, new ST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure(), ssConectaProveedores.RestRecords.RESTST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure.FromStructure, config);
  } else {
AttrPI_ITEM_EM3 = ssConectaProveedores.RestRecords.RESTST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure.FromStructure(s.ssSTPI_ITEM_EM3, config);
  }
}

public static RC_8f0936c3c24768761df4a411edbf9176 ToStructure(ssConectaProveedores.RestRecords.RESTRC_8f0936c3c24768761df4a411edbf9176 obj) { 
  RC_8f0936c3c24768761df4a411edbf9176 s = new RC_8f0936c3c24768761df4a411edbf9176();
  if(obj != null) {
  s.ssSTPI_ITEM_EM3 = ssConectaProveedores.RestRecords.RESTST_a84a1a1cfcb637021c4d3a23fe7a72d6Structure.ToStructure(obj.AttrPI_ITEM_EM3);
  }
  return s;
}

public static Func<RC_8f0936c3c24768761df4a411edbf9176, ssConectaProveedores.RestRecords.RESTRC_8f0936c3c24768761df4a411edbf9176> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8f0936c3c24768761df4a411edbf9176 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_8f0936c3c24768761df4a411edbf9176 FromStructure(RC_8f0936c3c24768761df4a411edbf9176 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_8f0936c3c24768761df4a411edbf9176(s, config);
}

}


