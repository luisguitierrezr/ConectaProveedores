using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioStructRecord
public class RESTRC_809967b191c14af33407e7f12d25eb73 : AbstractRESTStructure<RC_809967b191c14af33407e7f12d25eb73> {
[JsonProperty("FolioStruct")]
public ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure AttrFolioStruct;

public RESTRC_809967b191c14af33407e7f12d25eb73() { }

public RESTRC_809967b191c14af33407e7f12d25eb73 (RC_809967b191c14af33407e7f12d25eb73 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioStruct = ConvertToRestWithoutDefaults(s.ssSTFolioStruct, new ST_aa3e6001f162e602247a2e2cc13e2cf8Structure(), ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure.FromStructure, config);
  } else {
AttrFolioStruct = ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure.FromStructure(s.ssSTFolioStruct, config);
  }
}

public static RC_809967b191c14af33407e7f12d25eb73 ToStructure(ssConectaProveedores.RestRecords.RESTRC_809967b191c14af33407e7f12d25eb73 obj) { 
  RC_809967b191c14af33407e7f12d25eb73 s = new RC_809967b191c14af33407e7f12d25eb73();
  if(obj != null) {
  s.ssSTFolioStruct = ssConectaProveedores.RestRecords.RESTST_aa3e6001f162e602247a2e2cc13e2cf8Structure.ToStructure(obj.AttrFolioStruct);
  }
  return s;
}

public static Func<RC_809967b191c14af33407e7f12d25eb73, ssConectaProveedores.RestRecords.RESTRC_809967b191c14af33407e7f12d25eb73> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_809967b191c14af33407e7f12d25eb73 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_809967b191c14af33407e7f12d25eb73 FromStructure(RC_809967b191c14af33407e7f12d25eb73 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_809967b191c14af33407e7f12d25eb73(s, config);
}

}


