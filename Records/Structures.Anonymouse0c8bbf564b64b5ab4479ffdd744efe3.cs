namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (9bvI4LZkWku0R5_910Tv4w)
///  <code>RC_2929b54077988f623db253f22a62f498</code> that represent
/// s <code>OrderApprovalOrderApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderApprovalOrderApprovalLevelRecord
public partial struct RC_2929b54077988f623db253f22a62f498 : ITypedRecord<RC_2929b54077988f623db253f22a62f498> {
internal static readonly GlobalObjectKey IdOrderApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ix+DUUC_iYaxlr5dujqR6g");
internal static readonly GlobalObjectKey IdOrderApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*u4KD_7ZvfcxX7Np7tJmSLw");

public EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord ssENOrderApproval;

public EN_6b660d05e4c0025dff47119642875ca2EntityRecord ssENOrderApprovalLevel;


public BitArray OptimizedAttributes;

public RC_2929b54077988f623db253f22a62f498() {
OptimizedAttributes = null;
ssENOrderApproval = new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord();
ssENOrderApprovalLevel = new EN_6b660d05e4c0025dff47119642875ca2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(8,false);
    all[1] = new BitArray(17,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderApproval.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENOrderApproval.OptimizedAttributes = value[0];
    ssENOrderApprovalLevel.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENOrderApproval.OptimizedAttributes;
    all[1] = ssENOrderApprovalLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderApproval.Read( r, ref index);
ssENOrderApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_2929b54077988f623db253f22a62f498 r) {
this = r;
}


public static bool operator == (RC_2929b54077988f623db253f22a62f498 a, RC_2929b54077988f623db253f22a62f498 b) {
if (a.ssENOrderApproval != b.ssENOrderApproval) return false;
if (a.ssENOrderApprovalLevel != b.ssENOrderApprovalLevel) return false;
return true;
}

public static bool operator != (RC_2929b54077988f623db253f22a62f498 a, RC_2929b54077988f623db253f22a62f498 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2929b54077988f623db253f22a62f498)) return false;
return (this == (RC_2929b54077988f623db253f22a62f498)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderApproval.GetHashCode()
 ^ ssENOrderApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderApproval.RecursiveReset();
ssENOrderApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderApproval.InternalRecursiveSave();
ssENOrderApprovalLevel.InternalRecursiveSave();
}


public RC_2929b54077988f623db253f22a62f498 Duplicate() {
RC_2929b54077988f623db253f22a62f498 t;
t.ssENOrderApproval = (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord)this.ssENOrderApproval.Duplicate();
t.ssENOrderApprovalLevel = (EN_6b660d05e4c0025dff47119642875ca2EntityRecord)this.ssENOrderApprovalLevel.Duplicate();
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
if (head == "orderapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApproval")) variable.Value = ssENOrderApproval; else variable.Optimized = true;
variable.SetFieldName("orderapproval");
} else if (head == "orderapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApprovalLevel")) variable.Value = ssENOrderApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("orderapprovallevel");
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
if (key == IdOrderApproval) {
return ssENOrderApproval;
}
if (key == IdOrderApprovalLevel) {
return ssENOrderApprovalLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderApproval.Key.AsGuid) {
return ssENOrderApproval;
}
if (attributeKey == IdOrderApprovalLevel.Key.AsGuid) {
return ssENOrderApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderApproval.FillFromOther((IRecord) other.AttributeGet(IdOrderApproval));
ssENOrderApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdOrderApprovalLevel));
}
} // RC_2929b54077988f623db253f22a62f498
/// <summary>
/// RecordList type <code>OrderApprovalOrderApprovalLevelRecordList</code> that represents a record
///  list of <code>OrderApproval, OrderApprovalLevel</code>
/// </summary>
public partial class RL_3c2483fef931c35c62e6128a52ac9903 : GenericRecordList<RC_2929b54077988f623db253f22a62f498>, IEnumerable, IEnumerator {

protected override RC_2929b54077988f623db253f22a62f498 GetElementDefaultValue() {
return new RC_2929b54077988f623db253f22a62f498();
}

public T[] ToArray<T>(Func<RC_2929b54077988f623db253f22a62f498, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3c2483fef931c35c62e6128a52ac9903 recordList, Func<RC_2929b54077988f623db253f22a62f498, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3c2483fef931c35c62e6128a52ac9903(RC_2929b54077988f623db253f22a62f498[] array) {
  RL_3c2483fef931c35c62e6128a52ac9903 result = new RL_3c2483fef931c35c62e6128a52ac9903();
result.InnerFromArray(array);
    return result;
}

public static RL_3c2483fef931c35c62e6128a52ac9903 ToList<T>(T[] array, Func <T, RC_2929b54077988f623db253f22a62f498> converter) {
  RL_3c2483fef931c35c62e6128a52ac9903 result = new RL_3c2483fef931c35c62e6128a52ac9903();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3c2483fef931c35c62e6128a52ac9903 FromRestList<T>(RestList<T> restList, Func <T, RC_2929b54077988f623db253f22a62f498> converter) {
  RL_3c2483fef931c35c62e6128a52ac9903 result = new RL_3c2483fef931c35c62e6128a52ac9903();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3c2483fef931c35c62e6128a52ac9903() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(8,false);
def[1] = new BitArray(17,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_2929b54077988f623db253f22a62f498> NewList() {
return new RL_3c2483fef931c35c62e6128a52ac9903();
}


} // RL_3c2483fef931c35c62e6128a52ac9903
}

