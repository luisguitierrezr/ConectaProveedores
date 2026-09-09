using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// dataoutput2
public class JSONST_91300ad987a75a51816ab4149ce29870Structure : AbstractRESTStructure<ST_91300ad987a75a51816ab4149ce29870Structure> {
[JsonProperty("notificationlist")]
[JsonPropertyName("notificationlist")]
public ssConectaProveedores.RestRecords.JSONST_968b59b0d969f443f958cd852a31dcb5Structure[] Attrnotificationlist;

[JsonProperty("configurationlist")]
[JsonPropertyName("configurationlist")]
public ssConectaProveedores.RestRecords.JSONST_ba6d268a2af779386f4c1aef812147c5Structure[] Attrconfigurationlist;

[JsonProperty("checkedusers")]
[JsonPropertyName("checkedusers")]
public ssConectaProveedores.RestRecords.JSONST_06cbd1286b150e2e79c91e9d1ed3d811Structure Attrcheckedusers;

public JSONST_91300ad987a75a51816ab4149ce29870Structure() { }

public JSONST_91300ad987a75a51816ab4149ce29870Structure (ST_91300ad987a75a51816ab4149ce29870Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrnotificationlist = s.ssnotificationlist.Length == 0 ? null : s.ssnotificationlist.ToArray<ssConectaProveedores.RestRecords.JSONST_968b59b0d969f443f958cd852a31dcb5Structure>(ssConectaProveedores.RestRecords.JSONST_968b59b0d969f443f958cd852a31dcb5Structure.FromStructureDelegate(config));
Attrconfigurationlist = s.ssconfigurationlist.Length == 0 ? null : s.ssconfigurationlist.ToArray<ssConectaProveedores.RestRecords.JSONST_ba6d268a2af779386f4c1aef812147c5Structure>(ssConectaProveedores.RestRecords.JSONST_ba6d268a2af779386f4c1aef812147c5Structure.FromStructureDelegate(config));
Attrcheckedusers = ConvertToRestWithoutDefaults(s.sscheckedusers, new ST_06cbd1286b150e2e79c91e9d1ed3d811Structure(), ssConectaProveedores.RestRecords.JSONST_06cbd1286b150e2e79c91e9d1ed3d811Structure.FromStructure, config);
  } else {
Attrnotificationlist = s.ssnotificationlist.ToArray<ssConectaProveedores.RestRecords.JSONST_968b59b0d969f443f958cd852a31dcb5Structure>(ssConectaProveedores.RestRecords.JSONST_968b59b0d969f443f958cd852a31dcb5Structure.FromStructureDelegate(config));
Attrconfigurationlist = s.ssconfigurationlist.ToArray<ssConectaProveedores.RestRecords.JSONST_ba6d268a2af779386f4c1aef812147c5Structure>(ssConectaProveedores.RestRecords.JSONST_ba6d268a2af779386f4c1aef812147c5Structure.FromStructureDelegate(config));
Attrcheckedusers = ssConectaProveedores.RestRecords.JSONST_06cbd1286b150e2e79c91e9d1ed3d811Structure.FromStructure(s.sscheckedusers, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_91300ad987a75a51816ab4149ce29870Structure, ST_91300ad987a75a51816ab4149ce29870Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_91300ad987a75a51816ab4149ce29870Structure s) => ToStructure(s, config);
}
public static ST_91300ad987a75a51816ab4149ce29870Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_91300ad987a75a51816ab4149ce29870Structure obj, IBehaviorsConfiguration config) { 
  ST_91300ad987a75a51816ab4149ce29870Structure s = new ST_91300ad987a75a51816ab4149ce29870Structure();
  if(obj != null) {
  s.ssnotificationlist = RL_02b33a244546a7f09e6ac2e1170aaea2.ToList(obj.Attrnotificationlist, ssConectaProveedores.RestRecords.JSONST_968b59b0d969f443f958cd852a31dcb5Structure.ToStructureDelegate(config));
  s.ssconfigurationlist = RL_3ff9916e5a2a5558f61f2a757294606e.ToList(obj.Attrconfigurationlist, ssConectaProveedores.RestRecords.JSONST_ba6d268a2af779386f4c1aef812147c5Structure.ToStructureDelegate(config));
  s.sscheckedusers = ssConectaProveedores.RestRecords.JSONST_06cbd1286b150e2e79c91e9d1ed3d811Structure.ToStructure(obj.Attrcheckedusers, config);
  }
  return s;
}

public static Func<ST_91300ad987a75a51816ab4149ce29870Structure, ssConectaProveedores.RestRecords.JSONST_91300ad987a75a51816ab4149ce29870Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_91300ad987a75a51816ab4149ce29870Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_91300ad987a75a51816ab4149ce29870Structure FromStructure(ST_91300ad987a75a51816ab4149ce29870Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_91300ad987a75a51816ab4149ce29870Structure(s, config);
}

}


