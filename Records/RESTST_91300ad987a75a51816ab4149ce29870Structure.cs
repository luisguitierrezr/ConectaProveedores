using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// dataoutput2
public class RESTST_91300ad987a75a51816ab4149ce29870Structure : AbstractRESTStructure<ST_91300ad987a75a51816ab4149ce29870Structure> {
[JsonProperty("notificationlist")]
public RestList<ssConectaProveedores.RestRecords.RESTST_968b59b0d969f443f958cd852a31dcb5Structure> Attrnotificationlist;

[JsonProperty("configurationlist")]
public RestList<ssConectaProveedores.RestRecords.RESTST_ba6d268a2af779386f4c1aef812147c5Structure> Attrconfigurationlist;

[JsonProperty("checkedusers")]
public ssConectaProveedores.RestRecords.RESTST_06cbd1286b150e2e79c91e9d1ed3d811Structure Attrcheckedusers;

public RESTST_91300ad987a75a51816ab4149ce29870Structure() { }

public RESTST_91300ad987a75a51816ab4149ce29870Structure (ST_91300ad987a75a51816ab4149ce29870Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
Attrnotificationlist = s.ssnotificationlist.Length == 0 ? null : s.ssnotificationlist.ToRestList<ssConectaProveedores.RestRecords.RESTST_968b59b0d969f443f958cd852a31dcb5Structure>(ssConectaProveedores.RestRecords.RESTST_968b59b0d969f443f958cd852a31dcb5Structure.FromStructureDelegate(config));
Attrconfigurationlist = s.ssconfigurationlist.Length == 0 ? null : s.ssconfigurationlist.ToRestList<ssConectaProveedores.RestRecords.RESTST_ba6d268a2af779386f4c1aef812147c5Structure>(ssConectaProveedores.RestRecords.RESTST_ba6d268a2af779386f4c1aef812147c5Structure.FromStructureDelegate(config));
Attrcheckedusers = ConvertToRestWithoutDefaults(s.sscheckedusers, new ST_06cbd1286b150e2e79c91e9d1ed3d811Structure(), ssConectaProveedores.RestRecords.RESTST_06cbd1286b150e2e79c91e9d1ed3d811Structure.FromStructure, config);
  } else {
Attrnotificationlist = s.ssnotificationlist.ToRestList<ssConectaProveedores.RestRecords.RESTST_968b59b0d969f443f958cd852a31dcb5Structure>(ssConectaProveedores.RestRecords.RESTST_968b59b0d969f443f958cd852a31dcb5Structure.FromStructureDelegate(config));
Attrconfigurationlist = s.ssconfigurationlist.ToRestList<ssConectaProveedores.RestRecords.RESTST_ba6d268a2af779386f4c1aef812147c5Structure>(ssConectaProveedores.RestRecords.RESTST_ba6d268a2af779386f4c1aef812147c5Structure.FromStructureDelegate(config));
Attrcheckedusers = ssConectaProveedores.RestRecords.RESTST_06cbd1286b150e2e79c91e9d1ed3d811Structure.FromStructure(s.sscheckedusers, config);
  }
}

public static ST_91300ad987a75a51816ab4149ce29870Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_91300ad987a75a51816ab4149ce29870Structure obj) { 
  ST_91300ad987a75a51816ab4149ce29870Structure s = new ST_91300ad987a75a51816ab4149ce29870Structure();
  if(obj != null) {
  s.ssnotificationlist = RL_02b33a244546a7f09e6ac2e1170aaea2.FromRestList(obj.Attrnotificationlist, ssConectaProveedores.RestRecords.RESTST_968b59b0d969f443f958cd852a31dcb5Structure.ToStructure);
  s.ssconfigurationlist = RL_3ff9916e5a2a5558f61f2a757294606e.FromRestList(obj.Attrconfigurationlist, ssConectaProveedores.RestRecords.RESTST_ba6d268a2af779386f4c1aef812147c5Structure.ToStructure);
  s.sscheckedusers = ssConectaProveedores.RestRecords.RESTST_06cbd1286b150e2e79c91e9d1ed3d811Structure.ToStructure(obj.Attrcheckedusers);
  }
  return s;
}

public static Func<ST_91300ad987a75a51816ab4149ce29870Structure, ssConectaProveedores.RestRecords.RESTST_91300ad987a75a51816ab4149ce29870Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_91300ad987a75a51816ab4149ce29870Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_91300ad987a75a51816ab4149ce29870Structure FromStructure(ST_91300ad987a75a51816ab4149ce29870Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_91300ad987a75a51816ab4149ce29870Structure(s, config);
}

}


