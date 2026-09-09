using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MFU_FileRecord
public class RESTRC_eed89a9c1fe70a448325856911f34fe5 : AbstractRESTStructure<RC_eed89a9c1fe70a448325856911f34fe5> {
[JsonProperty("MFU_File")]
public ssConectaProveedores.RestRecords.RESTST_1d6498da9105fbe815a7f766352917c0Structure AttrMFU_File;

public RESTRC_eed89a9c1fe70a448325856911f34fe5() { }

public RESTRC_eed89a9c1fe70a448325856911f34fe5 (RC_eed89a9c1fe70a448325856911f34fe5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMFU_File = ConvertToRestWithoutDefaults(s.ssSTMFU_File, new ST_1d6498da9105fbe815a7f766352917c0Structure(), ssConectaProveedores.RestRecords.RESTST_1d6498da9105fbe815a7f766352917c0Structure.FromStructure, config);
  } else {
AttrMFU_File = ssConectaProveedores.RestRecords.RESTST_1d6498da9105fbe815a7f766352917c0Structure.FromStructure(s.ssSTMFU_File, config);
  }
}

public static RC_eed89a9c1fe70a448325856911f34fe5 ToStructure(ssConectaProveedores.RestRecords.RESTRC_eed89a9c1fe70a448325856911f34fe5 obj) { 
  RC_eed89a9c1fe70a448325856911f34fe5 s = new RC_eed89a9c1fe70a448325856911f34fe5();
  if(obj != null) {
  s.ssSTMFU_File = ssConectaProveedores.RestRecords.RESTST_1d6498da9105fbe815a7f766352917c0Structure.ToStructure(obj.AttrMFU_File);
  }
  return s;
}

public static Func<RC_eed89a9c1fe70a448325856911f34fe5, ssConectaProveedores.RestRecords.RESTRC_eed89a9c1fe70a448325856911f34fe5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_eed89a9c1fe70a448325856911f34fe5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_eed89a9c1fe70a448325856911f34fe5 FromStructure(RC_eed89a9c1fe70a448325856911f34fe5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_eed89a9c1fe70a448325856911f34fe5(s, config);
}

}


