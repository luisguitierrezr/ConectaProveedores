namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (P7TI4bBm5Uyf5EKD8GG9KQ)
///  <code>RC_7bf0e8779480c1f841bf78e3626ee944</code> that represent
/// s
///  <code>LastApproverFolioStatusFolioApprovalFolioFolioApprovalLevelLastFolioApprovalLevelApprovalStat
/// usOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: LastApproverFolioStatusFolioApprovalFolioFolioApprovalLevelLastFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord
public partial struct RC_7bf0e8779480c1f841bf78e3626ee944 : ITypedRecord<RC_7bf0e8779480c1f841bf78e3626ee944> {
internal static readonly GlobalObjectKey IdLastApprover = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*t7eC2lS6Ljk81WZ8N9erdg");
internal static readonly GlobalObjectKey IdFolioStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*svddx8bnSuc6Rd2nvXuT4g");
internal static readonly GlobalObjectKey IdFolioApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SSscj8sC0KLAy7X7HpeLUA");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdFolioApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5LroCyjMAlyIgitmOBjLbA");
internal static readonly GlobalObjectKey IdLastFolioApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*oKGRGkkAQ5JYh3jdT5yh3g");
internal static readonly GlobalObjectKey IdApprovalStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*C3GUXt6ghGRa8vnRzAiDAg");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdCanApprove = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*nLcAGQPQ4PqPs07608kMDw");
internal static readonly GlobalObjectKey IdDontShowAction = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*LJ45sa1N0YaIaQ3Ebk03wg");
internal static readonly GlobalObjectKey IdIsSelected = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*osqdCCbTPm0O_HzjZIVgPA");
internal static readonly GlobalObjectKey IdIsUserFromThisRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ORPO+yzvSoJSOlQpkhRWXg");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public ENUserEntityRecord ssENLastApprover;

public EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord ssENFolioStatus;

public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ssENFolioApproval;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFolioApprovalLevel;

public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENLastFolioApprovalLevel;

public EN_e97ac0d21205ff90ab42100bba6097baEntityRecord ssENApprovalStatus;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public bool ssCanApprove;

public bool ssDontShowAction;

public bool ssIsSelected;

public bool ssIsUserFromThisRegion;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_7bf0e8779480c1f841bf78e3626ee944() {
OptimizedAttributes = null;
ssENLastApprover = new ENUserEntityRecord();
ssENFolioStatus = new EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord();
ssENFolioApproval = new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENFolioApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
ssENLastFolioApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
ssENApprovalStatus = new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssCanApprove = false;
ssDontShowAction = false;
ssIsSelected = false;
ssIsUserFromThisRegion = false;
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[10];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(6,false);
    all[2] = new BitArray(10,false);
    all[3] = new BitArray(20,false);
    all[4] = new BitArray(20,false);
    all[5] = new BitArray(20,false);
    all[6] = new BitArray(10,false);
    all[7] = new BitArray(29,false);
    all[8] = new BitArray(28,false);
    all[9] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENLastApprover.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolioStatus.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolioApproval.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENFolioApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENLastFolioApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENApprovalStatus.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[8];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[9];
    }else{
    ssENLastApprover.OptimizedAttributes = value[0];
    ssENFolioStatus.OptimizedAttributes = value[1];
    ssENFolioApproval.OptimizedAttributes = value[2];
    ssENFolio.OptimizedAttributes = value[3];
    ssENFolioApprovalLevel.OptimizedAttributes = value[4];
    ssENLastFolioApprovalLevel.OptimizedAttributes = value[5];
    ssENApprovalStatus.OptimizedAttributes = value[6];
    ssENOrderMain.OptimizedAttributes = value[7];
    ssENSupplier.OptimizedAttributes = value[8];
    ssENRegion.OptimizedAttributes = value[9];
    }
}
get{
    BitArray[] all = new BitArray[10];
    all[0] = ssENLastApprover.OptimizedAttributes;
    all[1] = ssENFolioStatus.OptimizedAttributes;
    all[2] = ssENFolioApproval.OptimizedAttributes;
    all[3] = ssENFolio.OptimizedAttributes;
    all[4] = ssENFolioApprovalLevel.OptimizedAttributes;
    all[5] = ssENLastFolioApprovalLevel.OptimizedAttributes;
    all[6] = ssENApprovalStatus.OptimizedAttributes;
    all[7] = ssENOrderMain.OptimizedAttributes;
    all[8] = ssENSupplier.OptimizedAttributes;
    all[9] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENLastApprover.Read( r, ref index);
ssENFolioStatus.Read( r, ref index);
ssENFolioApproval.Read( r, ref index);
ssENFolio.Read( r, ref index);
ssENFolioApprovalLevel.Read( r, ref index);
ssENLastFolioApprovalLevel.Read( r, ref index);
ssENApprovalStatus.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssCanApprove = r.ReadBoolean(index++, "LastApproverFolioStatusFolioApprovalFolioFolioApprovalLevelLastFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.CanApprove", false);
ssDontShowAction = r.ReadBoolean(index++, "LastApproverFolioStatusFolioApprovalFolioFolioApprovalLevelLastFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.DontShowAction", false);
ssIsSelected = r.ReadBoolean(index++, "LastApproverFolioStatusFolioApprovalFolioFolioApprovalLevelLastFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.IsSelected", false);
ssIsUserFromThisRegion = r.ReadBoolean(index++, "LastApproverFolioStatusFolioApprovalFolioFolioApprovalLevelLastFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.IsUserFromThisRegion", false);
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
public void ReadIM(RC_7bf0e8779480c1f841bf78e3626ee944 r) {
this = r;
}


public static bool operator == (RC_7bf0e8779480c1f841bf78e3626ee944 a, RC_7bf0e8779480c1f841bf78e3626ee944 b) {
if (a.ssENLastApprover != b.ssENLastApprover) return false;
if (a.ssENFolioStatus != b.ssENFolioStatus) return false;
if (a.ssENFolioApproval != b.ssENFolioApproval) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENFolioApprovalLevel != b.ssENFolioApprovalLevel) return false;
if (a.ssENLastFolioApprovalLevel != b.ssENLastFolioApprovalLevel) return false;
if (a.ssENApprovalStatus != b.ssENApprovalStatus) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssCanApprove != b.ssCanApprove) return false;
if (a.ssDontShowAction != b.ssDontShowAction) return false;
if (a.ssIsSelected != b.ssIsSelected) return false;
if (a.ssIsUserFromThisRegion != b.ssIsUserFromThisRegion) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_7bf0e8779480c1f841bf78e3626ee944 a, RC_7bf0e8779480c1f841bf78e3626ee944 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7bf0e8779480c1f841bf78e3626ee944)) return false;
return (this == (RC_7bf0e8779480c1f841bf78e3626ee944)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENLastApprover.GetHashCode()
 ^ ssENFolioStatus.GetHashCode()
 ^ ssENFolioApproval.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENFolioApprovalLevel.GetHashCode()
 ^ ssENLastFolioApprovalLevel.GetHashCode()
 ^ ssENApprovalStatus.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
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
ssENLastApprover.RecursiveReset();
ssENFolioStatus.RecursiveReset();
ssENFolioApproval.RecursiveReset();
ssENFolio.RecursiveReset();
ssENFolioApprovalLevel.RecursiveReset();
ssENLastFolioApprovalLevel.RecursiveReset();
ssENApprovalStatus.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENLastApprover.InternalRecursiveSave();
ssENFolioStatus.InternalRecursiveSave();
ssENFolioApproval.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENFolioApprovalLevel.InternalRecursiveSave();
ssENLastFolioApprovalLevel.InternalRecursiveSave();
ssENApprovalStatus.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_7bf0e8779480c1f841bf78e3626ee944 Duplicate() {
RC_7bf0e8779480c1f841bf78e3626ee944 t;
t.ssENLastApprover = (ENUserEntityRecord)this.ssENLastApprover.Duplicate();
t.ssENFolioStatus = (EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord)this.ssENFolioStatus.Duplicate();
t.ssENFolioApproval = (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord)this.ssENFolioApproval.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENFolioApprovalLevel = (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord)this.ssENFolioApprovalLevel.Duplicate();
t.ssENLastFolioApprovalLevel = (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord)this.ssENLastFolioApprovalLevel.Duplicate();
t.ssENApprovalStatus = (EN_e97ac0d21205ff90ab42100bba6097baEntityRecord)this.ssENApprovalStatus.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
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
if (head == "lastapprover") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LastApprover")) variable.Value = ssENLastApprover; else variable.Optimized = true;
variable.SetFieldName("lastapprover");
} else if (head == "foliostatus") {
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
} else if (head == "lastfolioapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LastFolioApprovalLevel")) variable.Value = ssENLastFolioApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("lastfolioapprovallevel");
} else if (head == "approvalstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalStatus")) variable.Value = ssENApprovalStatus; else variable.Optimized = true;
variable.SetFieldName("approvalstatus");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
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
if (key == IdLastApprover) {
return ssENLastApprover;
}
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
if (key == IdLastFolioApprovalLevel) {
return ssENLastFolioApprovalLevel;
}
if (key == IdApprovalStatus) {
return ssENApprovalStatus;
}
if (key == IdOrderMain) {
return ssENOrderMain;
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
if (attributeKey == IdLastApprover.Key.AsGuid) {
return ssENLastApprover;
}
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
if (attributeKey == IdLastFolioApprovalLevel.Key.AsGuid) {
return ssENLastFolioApprovalLevel;
}
if (attributeKey == IdApprovalStatus.Key.AsGuid) {
return ssENApprovalStatus;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
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
ssENLastApprover.FillFromOther((IRecord) other.AttributeGet(IdLastApprover));
ssENFolioStatus.FillFromOther((IRecord) other.AttributeGet(IdFolioStatus));
ssENFolioApproval.FillFromOther((IRecord) other.AttributeGet(IdFolioApproval));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENFolioApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdFolioApprovalLevel));
ssENLastFolioApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdLastFolioApprovalLevel));
ssENApprovalStatus.FillFromOther((IRecord) other.AttributeGet(IdApprovalStatus));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssCanApprove = (bool) other.AttributeGet(IdCanApprove);
ssDontShowAction = (bool) other.AttributeGet(IdDontShowAction);
ssIsSelected = (bool) other.AttributeGet(IdIsSelected);
ssIsUserFromThisRegion = (bool) other.AttributeGet(IdIsUserFromThisRegion);
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_7bf0e8779480c1f841bf78e3626ee944
/// <summary>
/// RecordList type
///  <code>LastApproverFolioStatusFolioApprovalFolioFolioApprovalLevelLastFolioApprovalLevelApprovalStat
/// usOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecordList</code>
///  that represents a record list of <code>User, FolioStatus, FolioApproval, Folio, FolioApprovalLevel
/// , FolioApprovalLevel, ApprovalStatus, OrderMain, Boolean, Boolean, Boolean, Boolean, Supplier,
///  Region</code>
/// </summary>
public partial class RL_03e3cf3b917f5a94fbd0a8404cd2dee5 : GenericRecordList<RC_7bf0e8779480c1f841bf78e3626ee944>, IEnumerable, IEnumerator {

protected override RC_7bf0e8779480c1f841bf78e3626ee944 GetElementDefaultValue() {
return new RC_7bf0e8779480c1f841bf78e3626ee944();
}

public T[] ToArray<T>(Func<RC_7bf0e8779480c1f841bf78e3626ee944, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_03e3cf3b917f5a94fbd0a8404cd2dee5 recordList, Func<RC_7bf0e8779480c1f841bf78e3626ee944, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_03e3cf3b917f5a94fbd0a8404cd2dee5(RC_7bf0e8779480c1f841bf78e3626ee944[] array) {
  RL_03e3cf3b917f5a94fbd0a8404cd2dee5 result = new RL_03e3cf3b917f5a94fbd0a8404cd2dee5();
result.InnerFromArray(array);
    return result;
}

public static RL_03e3cf3b917f5a94fbd0a8404cd2dee5 ToList<T>(T[] array, Func <T, RC_7bf0e8779480c1f841bf78e3626ee944> converter) {
  RL_03e3cf3b917f5a94fbd0a8404cd2dee5 result = new RL_03e3cf3b917f5a94fbd0a8404cd2dee5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_03e3cf3b917f5a94fbd0a8404cd2dee5 FromRestList<T>(RestList<T> restList, Func <T, RC_7bf0e8779480c1f841bf78e3626ee944> converter) {
  RL_03e3cf3b917f5a94fbd0a8404cd2dee5 result = new RL_03e3cf3b917f5a94fbd0a8404cd2dee5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_03e3cf3b917f5a94fbd0a8404cd2dee5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[10];
def[0] = new BitArray(5,false);
def[1] = new BitArray(6,false);
def[2] = new BitArray(10,false);
def[3] = new BitArray(20,false);
def[4] = new BitArray(20,false);
def[5] = new BitArray(20,false);
def[6] = new BitArray(10,false);
def[7] = new BitArray(29,false);
def[8] = new BitArray(28,false);
def[9] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7bf0e8779480c1f841bf78e3626ee944> NewList() {
return new RL_03e3cf3b917f5a94fbd0a8404cd2dee5();
}


} // RL_03e3cf3b917f5a94fbd0a8404cd2dee5
}

