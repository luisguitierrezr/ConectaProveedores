using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CountRecord
public class RESTRC_76b1ff1d6a963752b041dfef3f1cb835 : AbstractRESTStructure<RC_76b1ff1d6a963752b041dfef3f1cb835> {
[JsonProperty("Count")]
public long? AttrCount;

public RESTRC_76b1ff1d6a963752b041dfef3f1cb835() { }

public RESTRC_76b1ff1d6a963752b041dfef3f1cb835 (RC_76b1ff1d6a963752b041dfef3f1cb835 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCount = ConvertToRestWithoutDefaults(s.ssCount, 0L);
  } else {
AttrCount = (long?) s.ssCount;
  }
}

public static RC_76b1ff1d6a963752b041dfef3f1cb835 ToStructure(ssConectaProveedores.RestRecords.RESTRC_76b1ff1d6a963752b041dfef3f1cb835 obj) { 
  RC_76b1ff1d6a963752b041dfef3f1cb835 s = new RC_76b1ff1d6a963752b041dfef3f1cb835();
  if(obj != null) {
  s.ssCount = obj.AttrCount == null ? 0L : obj.AttrCount.Value;
  }
  return s;
}

public static Func<RC_76b1ff1d6a963752b041dfef3f1cb835, ssConectaProveedores.RestRecords.RESTRC_76b1ff1d6a963752b041dfef3f1cb835> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_76b1ff1d6a963752b041dfef3f1cb835 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_76b1ff1d6a963752b041dfef3f1cb835 FromStructure(RC_76b1ff1d6a963752b041dfef3f1cb835 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_76b1ff1d6a963752b041dfef3f1cb835(s, config);
}

}


