namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (0dQxK1tT0U6BLrzhafKb+Q)
///  <code>RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c</code> that represent
/// s <code>FolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainRecord</code> <p>Description:
///  </p>
/// </summary>
// Name: FolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainRecord
public partial struct RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c : ITypedRecord<RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c> {
internal static readonly GlobalObjectKey IdFolioApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SSscj8sC0KLAy7X7HpeLUA");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdFolioApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5LroCyjMAlyIgitmOBjLbA");
internal static readonly GlobalObjectKey IdApprovalStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*C3GUXt6ghGRa8vnRzAiDAg");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");

public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ssENFolioApproval;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFolioApprovalLevel;

public EN_e97ac0d21205ff90ab42100bba6097baEntityRecord ssENApprovalStatus;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;


public BitArray OptimizedAttributes;

public RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c() {
OptimizedAttributes = null;
ssENFolioApproval = new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENFolioApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
ssENApprovalStatus = new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(10,false);
    all[1] = new BitArray(20,false);
    all[2] = new BitArray(20,false);
    all[3] = new BitArray(10,false);
    all[4] = new BitArray(29,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioApproval.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolioApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENApprovalStatus.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENFolioApproval.OptimizedAttributes = value[0];
    ssENFolio.OptimizedAttributes = value[1];
    ssENFolioApprovalLevel.OptimizedAttributes = value[2];
    ssENApprovalStatus.OptimizedAttributes = value[3];
    ssENOrderMain.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENFolioApproval.OptimizedAttributes;
    all[1] = ssENFolio.OptimizedAttributes;
    all[2] = ssENFolioApprovalLevel.OptimizedAttributes;
    all[3] = ssENApprovalStatus.OptimizedAttributes;
    all[4] = ssENOrderMain.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioApproval.Read( r, ref index);
ssENFolio.Read( r, ref index);
ssENFolioApprovalLevel.Read( r, ref index);
ssENApprovalStatus.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
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
public void ReadIM(RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c r) {
this = r;
}


public static bool operator == (RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c a, RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c b) {
if (a.ssENFolioApproval != b.ssENFolioApproval) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENFolioApprovalLevel != b.ssENFolioApprovalLevel) return false;
if (a.ssENApprovalStatus != b.ssENApprovalStatus) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
return true;
}

public static bool operator != (RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c a, RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c)) return false;
return (this == (RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioApproval.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENFolioApprovalLevel.GetHashCode()
 ^ ssENApprovalStatus.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioApproval.RecursiveReset();
ssENFolio.RecursiveReset();
ssENFolioApprovalLevel.RecursiveReset();
ssENApprovalStatus.RecursiveReset();
ssENOrderMain.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioApproval.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENFolioApprovalLevel.InternalRecursiveSave();
ssENApprovalStatus.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
}


public RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c Duplicate() {
RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c t;
t.ssENFolioApproval = (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord)this.ssENFolioApproval.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENFolioApprovalLevel = (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord)this.ssENFolioApprovalLevel.Duplicate();
t.ssENApprovalStatus = (EN_e97ac0d21205ff90ab42100bba6097baEntityRecord)this.ssENApprovalStatus.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
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
if (head == "folioapproval") {
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
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
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioApproval.FillFromOther((IRecord) other.AttributeGet(IdFolioApproval));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENFolioApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdFolioApprovalLevel));
ssENApprovalStatus.FillFromOther((IRecord) other.AttributeGet(IdApprovalStatus));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
}
} // RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c
/// <summary>
/// RecordList type <code>FolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainRecordList</code>
///  that represents a record list of <code>FolioApproval, Folio, FolioApprovalLevel, ApprovalStatus
/// , OrderMain</code>
/// </summary>
public partial class RL_f5eb3106ade23782adf73cebbee7b2af : GenericRecordList<RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c>, IEnumerable, IEnumerator {

protected override RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c GetElementDefaultValue() {
return new RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c();
}

public T[] ToArray<T>(Func<RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f5eb3106ade23782adf73cebbee7b2af recordList, Func<RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f5eb3106ade23782adf73cebbee7b2af(RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c[] array) {
  RL_f5eb3106ade23782adf73cebbee7b2af result = new RL_f5eb3106ade23782adf73cebbee7b2af();
result.InnerFromArray(array);
    return result;
}

public static RL_f5eb3106ade23782adf73cebbee7b2af ToList<T>(T[] array, Func <T, RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c> converter) {
  RL_f5eb3106ade23782adf73cebbee7b2af result = new RL_f5eb3106ade23782adf73cebbee7b2af();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f5eb3106ade23782adf73cebbee7b2af FromRestList<T>(RestList<T> restList, Func <T, RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c> converter) {
  RL_f5eb3106ade23782adf73cebbee7b2af result = new RL_f5eb3106ade23782adf73cebbee7b2af();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f5eb3106ade23782adf73cebbee7b2af() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(10,false);
def[1] = new BitArray(20,false);
def[2] = new BitArray(20,false);
def[3] = new BitArray(10,false);
def[4] = new BitArray(29,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c17160362ea0f1b8ed4d2b4bb1d6ed6c> NewList() {
return new RL_f5eb3106ade23782adf73cebbee7b2af();
}


} // RL_f5eb3106ade23782adf73cebbee7b2af
}

