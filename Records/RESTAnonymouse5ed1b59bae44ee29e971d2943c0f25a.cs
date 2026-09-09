using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ErrorMessageRecord
public class RESTRC_27b5a164e828de9b90686831c7908b4a : AbstractRESTStructure<RC_27b5a164e828de9b90686831c7908b4a> {
[JsonProperty("ErrorMessage")]
public ssConectaProveedores.RestRecords.RESTST_b7d405ca4407e572da091e54d07e3bd1Structure AttrErrorMessage;

public RESTRC_27b5a164e828de9b90686831c7908b4a() { }

public RESTRC_27b5a164e828de9b90686831c7908b4a (RC_27b5a164e828de9b90686831c7908b4a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrErrorMessage = ConvertToRestWithoutDefaults(s.ssSTErrorMessage, new ST_b7d405ca4407e572da091e54d07e3bd1Structure(), ssConectaProveedores.RestRecords.RESTST_b7d405ca4407e572da091e54d07e3bd1Structure.FromStructure, config);
  } else {
AttrErrorMessage = ssConectaProveedores.RestRecords.RESTST_b7d405ca4407e572da091e54d07e3bd1Structure.FromStructure(s.ssSTErrorMessage, config);
  }
}

public static RC_27b5a164e828de9b90686831c7908b4a ToStructure(ssConectaProveedores.RestRecords.RESTRC_27b5a164e828de9b90686831c7908b4a obj) { 
  RC_27b5a164e828de9b90686831c7908b4a s = new RC_27b5a164e828de9b90686831c7908b4a();
  if(obj != null) {
  s.ssSTErrorMessage = ssConectaProveedores.RestRecords.RESTST_b7d405ca4407e572da091e54d07e3bd1Structure.ToStructure(obj.AttrErrorMessage);
  }
  return s;
}

public static Func<RC_27b5a164e828de9b90686831c7908b4a, ssConectaProveedores.RestRecords.RESTRC_27b5a164e828de9b90686831c7908b4a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_27b5a164e828de9b90686831c7908b4a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_27b5a164e828de9b90686831c7908b4a FromStructure(RC_27b5a164e828de9b90686831c7908b4a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_27b5a164e828de9b90686831c7908b4a(s, config);
}

}


