namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (5PsjM7_DzU610GmCi+BQQw)
///  <code>RC_497f735a522829d94999357ea05280c6</code> that represent
/// s <code>FolioApprovalFolioFolioApprovalLevelOrderMainRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioApprovalFolioFolioApprovalLevelOrderMainRecord
public partial struct RC_497f735a522829d94999357ea05280c6 : ITypedRecord<RC_497f735a522829d94999357ea05280c6> {
internal static readonly GlobalObjectKey IdFolioApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SSscj8sC0KLAy7X7HpeLUA");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdFolioApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5LroCyjMAlyIgitmOBjLbA");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");

public EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord ssENFolioApproval;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord ssENFolioApprovalLevel;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;


public BitArray OptimizedAttributes;

public RC_497f735a522829d94999357ea05280c6() {
OptimizedAttributes = null;
ssENFolioApproval = new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENFolioApprovalLevel = new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(10,false);
    all[1] = new BitArray(20,false);
    all[2] = new BitArray(20,false);
    all[3] = new BitArray(29,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioApproval.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolioApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENFolioApproval.OptimizedAttributes = value[0];
    ssENFolio.OptimizedAttributes = value[1];
    ssENFolioApprovalLevel.OptimizedAttributes = value[2];
    ssENOrderMain.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENFolioApproval.OptimizedAttributes;
    all[1] = ssENFolio.OptimizedAttributes;
    all[2] = ssENFolioApprovalLevel.OptimizedAttributes;
    all[3] = ssENOrderMain.OptimizedAttributes;
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
public void ReadIM(RC_497f735a522829d94999357ea05280c6 r) {
this = r;
}


public static bool operator == (RC_497f735a522829d94999357ea05280c6 a, RC_497f735a522829d94999357ea05280c6 b) {
if (a.ssENFolioApproval != b.ssENFolioApproval) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENFolioApprovalLevel != b.ssENFolioApprovalLevel) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
return true;
}

public static bool operator != (RC_497f735a522829d94999357ea05280c6 a, RC_497f735a522829d94999357ea05280c6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_497f735a522829d94999357ea05280c6)) return false;
return (this == (RC_497f735a522829d94999357ea05280c6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioApproval.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENFolioApprovalLevel.GetHashCode()
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
ssENOrderMain.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioApproval.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENFolioApprovalLevel.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
}


public RC_497f735a522829d94999357ea05280c6 Duplicate() {
RC_497f735a522829d94999357ea05280c6 t;
t.ssENFolioApproval = (EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord)this.ssENFolioApproval.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENFolioApprovalLevel = (EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord)this.ssENFolioApprovalLevel.Duplicate();
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
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
}
} // RC_497f735a522829d94999357ea05280c6
/// <summary>
/// RecordList type <code>FolioApprovalFolioFolioApprovalLevelOrderMainRecordList</code> that
///  represents a record list of <code>FolioApproval, Folio, FolioApprovalLevel, OrderMain</code>
/// </summary>
public partial class RL_57593cd225237ead1eaddf28b138c8a4 : GenericRecordList<RC_497f735a522829d94999357ea05280c6>, IEnumerable, IEnumerator {

protected override RC_497f735a522829d94999357ea05280c6 GetElementDefaultValue() {
return new RC_497f735a522829d94999357ea05280c6();
}

public T[] ToArray<T>(Func<RC_497f735a522829d94999357ea05280c6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_57593cd225237ead1eaddf28b138c8a4 recordList, Func<RC_497f735a522829d94999357ea05280c6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_57593cd225237ead1eaddf28b138c8a4(RC_497f735a522829d94999357ea05280c6[] array) {
  RL_57593cd225237ead1eaddf28b138c8a4 result = new RL_57593cd225237ead1eaddf28b138c8a4();
result.InnerFromArray(array);
    return result;
}

public static RL_57593cd225237ead1eaddf28b138c8a4 ToList<T>(T[] array, Func <T, RC_497f735a522829d94999357ea05280c6> converter) {
  RL_57593cd225237ead1eaddf28b138c8a4 result = new RL_57593cd225237ead1eaddf28b138c8a4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_57593cd225237ead1eaddf28b138c8a4 FromRestList<T>(RestList<T> restList, Func <T, RC_497f735a522829d94999357ea05280c6> converter) {
  RL_57593cd225237ead1eaddf28b138c8a4 result = new RL_57593cd225237ead1eaddf28b138c8a4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_57593cd225237ead1eaddf28b138c8a4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(10,false);
def[1] = new BitArray(20,false);
def[2] = new BitArray(20,false);
def[3] = new BitArray(29,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_497f735a522829d94999357ea05280c6> NewList() {
return new RL_57593cd225237ead1eaddf28b138c8a4();
}


} // RL_57593cd225237ead1eaddf28b138c8a4
}

