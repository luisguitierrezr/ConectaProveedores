namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (XG2RD0hDHUyyrQLy2+u8Xg)
///  <code>RC_d7d7e269eeb924718adc0d2a0b1d922d</code> that represent
/// s
///  <code>FolioStatusFolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainApplicationRoleCanAppro
/// veDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioStatusFolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainApplicationRoleCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord
public partial struct RC_d7d7e269eeb924718adc0d2a0b1d922d : ITypedRecord<RC_d7d7e269eeb924718adc0d2a0b1d922d> {
internal static readonly GlobalObjectKey IdFolioStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*svddx8bnSuc6Rd2nvXuT4g");
internal static readonly GlobalObjectKey IdFolioApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SSscj8sC0KLAy7X7HpeLUA");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdFolioApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5LroCyjMAlyIgitmOBjLbA");
internal static readonly GlobalObjectKey IdApprovalStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*C3GUXt6ghGRa8vnRzAiDAg");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");
internal static readonly GlobalObjectKey IdCanApprove = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*nLcAGQPQ4PqPs07608kMDw");
internal static readonly GlobalObjectKey IdDontShowAction = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*LJ45sa1N0YaIaQ3Ebk03wg");
internal static readonly GlobalObjectKey IdIsSelected = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*osqdCCbTPm0O_HzjZIVgPA");
internal static readonly GlobalObjectKey IdIsUserFromThisRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ORPO+yzvSoJSOlQpkhRWXg");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord ssENFolioStatus;

public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ssENFolioApproval;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFolioApprovalLevel;

public EN_e97ac0d21205ff90ab42100bba6097baEntityRecord ssENApprovalStatus;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;

public bool ssCanApprove;

public bool ssDontShowAction;

public bool ssIsSelected;

public bool ssIsUserFromThisRegion;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_d7d7e269eeb924718adc0d2a0b1d922d() {
OptimizedAttributes = null;
ssENFolioStatus = new EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord();
ssENFolioApproval = new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENFolioApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
ssENApprovalStatus = new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
ssCanApprove = false;
ssDontShowAction = false;
ssIsSelected = false;
ssIsUserFromThisRegion = false;
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[9];
    all[0] = new BitArray(6,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(20,false);
    all[3] = new BitArray(20,false);
    all[4] = new BitArray(10,false);
    all[5] = new BitArray(29,false);
    all[6] = new BitArray(7,false);
    all[7] = new BitArray(28,false);
    all[8] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolioApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENFolioApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENApprovalStatus.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[8];
    }else{
    ssENFolioStatus.OptimizedAttributes = value[0];
    ssENFolioApproval.OptimizedAttributes = value[1];
    ssENFolio.OptimizedAttributes = value[2];
    ssENFolioApprovalLevel.OptimizedAttributes = value[3];
    ssENApprovalStatus.OptimizedAttributes = value[4];
    ssENOrderMain.OptimizedAttributes = value[5];
    ssENApplicationRole.OptimizedAttributes = value[6];
    ssENSupplier.OptimizedAttributes = value[7];
    ssENRegion.OptimizedAttributes = value[8];
    }
}
get{
    BitArray[] all = new BitArray[9];
    all[0] = ssENFolioStatus.OptimizedAttributes;
    all[1] = ssENFolioApproval.OptimizedAttributes;
    all[2] = ssENFolio.OptimizedAttributes;
    all[3] = ssENFolioApprovalLevel.OptimizedAttributes;
    all[4] = ssENApprovalStatus.OptimizedAttributes;
    all[5] = ssENOrderMain.OptimizedAttributes;
    all[6] = ssENApplicationRole.OptimizedAttributes;
    all[7] = ssENSupplier.OptimizedAttributes;
    all[8] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioStatus.Read( r, ref index);
ssENFolioApproval.Read( r, ref index);
ssENFolio.Read( r, ref index);
ssENFolioApprovalLevel.Read( r, ref index);
ssENApprovalStatus.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENApplicationRole.Read( r, ref index);
ssCanApprove = r.ReadBoolean(index++, "FolioStatusFolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainApplicationRoleCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.CanApprove", false);
ssDontShowAction = r.ReadBoolean(index++, "FolioStatusFolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainApplicationRoleCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.DontShowAction", false);
ssIsSelected = r.ReadBoolean(index++, "FolioStatusFolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainApplicationRoleCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.IsSelected", false);
ssIsUserFromThisRegion = r.ReadBoolean(index++, "FolioStatusFolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainApplicationRoleCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.IsUserFromThisRegion", false);
ssENSupplier.Read( r, ref index);
ssENRegion.Read( r, ref index);
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(RC_d7d7e269eeb924718adc0d2a0b1d922d r) {
this = r;
}


public static bool operator == (RC_d7d7e269eeb924718adc0d2a0b1d922d a, RC_d7d7e269eeb924718adc0d2a0b1d922d b) {
if (a.ssENFolioStatus != b.ssENFolioStatus) return false;
if (a.ssENFolioApproval != b.ssENFolioApproval) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENFolioApprovalLevel != b.ssENFolioApprovalLevel) return false;
if (a.ssENApprovalStatus != b.ssENApprovalStatus) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
if (a.ssCanApprove != b.ssCanApprove) return false;
if (a.ssDontShowAction != b.ssDontShowAction) return false;
if (a.ssIsSelected != b.ssIsSelected) return false;
if (a.ssIsUserFromThisRegion != b.ssIsUserFromThisRegion) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_d7d7e269eeb924718adc0d2a0b1d922d a, RC_d7d7e269eeb924718adc0d2a0b1d922d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d7d7e269eeb924718adc0d2a0b1d922d)) return false;
return (this == (RC_d7d7e269eeb924718adc0d2a0b1d922d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioStatus.GetHashCode()
 ^ ssENFolioApproval.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENFolioApprovalLevel.GetHashCode()
 ^ ssENApprovalStatus.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
 ^ ssCanApprove.GetHashCode()
 ^ ssDontShowAction.GetHashCode()
 ^ ssIsSelected.GetHashCode()
 ^ ssIsUserFromThisRegion.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioStatus.RecursiveReset();
ssENFolioApproval.RecursiveReset();
ssENFolio.RecursiveReset();
ssENFolioApprovalLevel.RecursiveReset();
ssENApprovalStatus.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENApplicationRole.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioStatus.InternalRecursiveSave();
ssENFolioApproval.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENFolioApprovalLevel.InternalRecursiveSave();
ssENApprovalStatus.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_d7d7e269eeb924718adc0d2a0b1d922d Duplicate() {
RC_d7d7e269eeb924718adc0d2a0b1d922d t;
t.ssENFolioStatus = (EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord)this.ssENFolioStatus.Duplicate();
t.ssENFolioApproval = (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord)this.ssENFolioApproval.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENFolioApprovalLevel = (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord)this.ssENFolioApprovalLevel.Duplicate();
t.ssENApprovalStatus = (EN_e97ac0d21205ff90ab42100bba6097baEntityRecord)this.ssENApprovalStatus.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
t.ssCanApprove = this.ssCanApprove;
t.ssDontShowAction = this.ssDontShowAction;
t.ssIsSelected = this.ssIsSelected;
t.ssIsUserFromThisRegion = this.ssIsUserFromThisRegion;
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "foliostatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioStatus")) variable.Value = ssENFolioStatus; else variable.Optimized = true;
variable.SetFieldName("foliostatus");
} else if (head == "folioapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApproval")) variable.Value = ssENFolioApproval; else variable.Optimized = true;
variable.SetFieldName("folioapproval");
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "folioapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioApprovalLevel")) variable.Value = ssENFolioApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("folioapprovallevel");
} else if (head == "approvalstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalStatus")) variable.Value = ssENApprovalStatus; else variable.Optimized = true;
variable.SetFieldName("approvalstatus");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "applicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRole")) variable.Value = ssENApplicationRole; else variable.Optimized = true;
variable.SetFieldName("applicationrole");
} else if (head == "canapprove") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CanApprove")) variable.Value = ssCanApprove; else variable.Optimized = true;
} else if (head == "dontshowaction") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DontShowAction")) variable.Value = ssDontShowAction; else variable.Optimized = true;
} else if (head == "isselected") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSelected")) variable.Value = ssIsSelected; else variable.Optimized = true;
} else if (head == "isuserfromthisregion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsUserFromThisRegion")) variable.Value = ssIsUserFromThisRegion; else variable.Optimized = true;
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFolioStatus) {
return ssENFolioStatus;
}
if (key == IdFolioApproval) {
return ssENFolioApproval;
}
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdFolioApprovalLevel) {
return ssENFolioApprovalLevel;
}
if (key == IdApprovalStatus) {
return ssENApprovalStatus;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdApplicationRole) {
return ssENApplicationRole;
}
if (key == IdCanApprove) {
return ssCanApprove;
}
if (key == IdDontShowAction) {
return ssDontShowAction;
}
if (key == IdIsSelected) {
return ssIsSelected;
}
if (key == IdIsUserFromThisRegion) {
return ssIsUserFromThisRegion;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioStatus.Key.AsGuid) {
return ssENFolioStatus;
}
if (attributeKey == IdFolioApproval.Key.AsGuid) {
return ssENFolioApproval;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdFolioApprovalLevel.Key.AsGuid) {
return ssENFolioApprovalLevel;
}
if (attributeKey == IdApprovalStatus.Key.AsGuid) {
return ssENApprovalStatus;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
if (attributeKey == IdCanApprove.Key.AsGuid) {
return ssCanApprove;
}
if (attributeKey == IdDontShowAction.Key.AsGuid) {
return ssDontShowAction;
}
if (attributeKey == IdIsSelected.Key.AsGuid) {
return ssIsSelected;
}
if (attributeKey == IdIsUserFromThisRegion.Key.AsGuid) {
return ssIsUserFromThisRegion;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioStatus.FillFromOther((IRecord) other.AttributeGet(IdFolioStatus));
ssENFolioApproval.FillFromOther((IRecord) other.AttributeGet(IdFolioApproval));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENFolioApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdFolioApprovalLevel));
ssENApprovalStatus.FillFromOther((IRecord) other.AttributeGet(IdApprovalStatus));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
ssCanApprove = (bool) other.AttributeGet(IdCanApprove);
ssDontShowAction = (bool) other.AttributeGet(IdDontShowAction);
ssIsSelected = (bool) other.AttributeGet(IdIsSelected);
ssIsUserFromThisRegion = (bool) other.AttributeGet(IdIsUserFromThisRegion);
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_d7d7e269eeb924718adc0d2a0b1d922d
/// <summary>
/// RecordList type
///  <code>FolioStatusFolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainApplicationRoleCanAppro
/// veDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecordList</code> that represents a
///  record list of <code>FolioStatus, FolioApproval, Folio, FolioApprovalLevel, ApprovalStatus
/// , OrderMain, ApplicationRole, Boolean, Boolean, Boolean, Boolean, Supplier, Region</code>
/// </summary>
public partial class RL_c2883fff640d266ea46702d7f4b1c10f : GenericRecordList<RC_d7d7e269eeb924718adc0d2a0b1d922d>, IEnumerable, IEnumerator {

protected override RC_d7d7e269eeb924718adc0d2a0b1d922d GetElementDefaultValue() {
return new RC_d7d7e269eeb924718adc0d2a0b1d922d();
}

public T[] ToArray<T>(Func<RC_d7d7e269eeb924718adc0d2a0b1d922d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c2883fff640d266ea46702d7f4b1c10f recordList, Func<RC_d7d7e269eeb924718adc0d2a0b1d922d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c2883fff640d266ea46702d7f4b1c10f(RC_d7d7e269eeb924718adc0d2a0b1d922d[] array) {
  RL_c2883fff640d266ea46702d7f4b1c10f result = new RL_c2883fff640d266ea46702d7f4b1c10f();
result.InnerFromArray(array);
    return result;
}

public static RL_c2883fff640d266ea46702d7f4b1c10f ToList<T>(T[] array, Func <T, RC_d7d7e269eeb924718adc0d2a0b1d922d> converter) {
  RL_c2883fff640d266ea46702d7f4b1c10f result = new RL_c2883fff640d266ea46702d7f4b1c10f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c2883fff640d266ea46702d7f4b1c10f FromRestList<T>(RestList<T> restList, Func <T, RC_d7d7e269eeb924718adc0d2a0b1d922d> converter) {
  RL_c2883fff640d266ea46702d7f4b1c10f result = new RL_c2883fff640d266ea46702d7f4b1c10f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c2883fff640d266ea46702d7f4b1c10f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[9];
def[0] = new BitArray(6,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(20,false);
def[3] = new BitArray(20,false);
def[4] = new BitArray(10,false);
def[5] = new BitArray(29,false);
def[6] = new BitArray(7,false);
def[7] = new BitArray(28,false);
def[8] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d7d7e269eeb924718adc0d2a0b1d922d> NewList() {
return new RL_c2883fff640d266ea46702d7f4b1c10f();
}


} // RL_c2883fff640d266ea46702d7f4b1c10f
}

