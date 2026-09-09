using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_COSMOZ_RequestRecord
public class RESTRC_7d4bec7bab5f921632c0f5cba3ea0ec2 : AbstractRESTStructure<RC_7d4bec7bab5f921632c0f5cba3ea0ec2> {
[JsonProperty("EM_COSMOZ_Request")]
public ssConectaProveedores.RestRecords.RESTST_471afc38d91cd307b39846c7ca5ddb86Structure AttrEM_COSMOZ_Request;

public RESTRC_7d4bec7bab5f921632c0f5cba3ea0ec2() { }

public RESTRC_7d4bec7bab5f921632c0f5cba3ea0ec2 (RC_7d4bec7bab5f921632c0f5cba3ea0ec2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_COSMOZ_Request = ConvertToRestWithoutDefaults(s.ssSTEM_COSMOZ_Request, new ST_471afc38d91cd307b39846c7ca5ddb86Structure(), ssConectaProveedores.RestRecords.RESTST_471afc38d91cd307b39846c7ca5ddb86Structure.FromStructure, config);
  } else {
AttrEM_COSMOZ_Request = ssConectaProveedores.RestRecords.RESTST_471afc38d91cd307b39846c7ca5ddb86Structure.FromStructure(s.ssSTEM_COSMOZ_Request, config);
  }
}

public static RC_7d4bec7bab5f921632c0f5cba3ea0ec2 ToStructure(ssConectaProveedores.RestRecords.RESTRC_7d4bec7bab5f921632c0f5cba3ea0ec2 obj) { 
  RC_7d4bec7bab5f921632c0f5cba3ea0ec2 s = new RC_7d4bec7bab5f921632c0f5cba3ea0ec2();
  if(obj != null) {
  s.ssSTEM_COSMOZ_Request = ssConectaProveedores.RestRecords.RESTST_471afc38d91cd307b39846c7ca5ddb86Structure.ToStructure(obj.AttrEM_COSMOZ_Request);
  }
  return s;
}

public static Func<RC_7d4bec7bab5f921632c0f5cba3ea0ec2, ssConectaProveedores.RestRecords.RESTRC_7d4bec7bab5f921632c0f5cba3ea0ec2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7d4bec7bab5f921632c0f5cba3ea0ec2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_7d4bec7bab5f921632c0f5cba3ea0ec2 FromStructure(RC_7d4bec7bab5f921632c0f5cba3ea0ec2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_7d4bec7bab5f921632c0f5cba3ea0ec2(s, config);
}

}


