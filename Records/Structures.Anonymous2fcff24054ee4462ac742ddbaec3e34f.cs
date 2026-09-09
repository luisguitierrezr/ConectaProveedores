namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (QPLPL+5UYkSsdC3brsPjTw)
///  <code>RC_7f0ffeffec7d0864eb8855fe8e873743</code> that represents <code>OrderDetailRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OrderDetailRecord
public partial struct RC_7f0ffeffec7d0864eb8855fe8e873743 : ITypedRecord<RC_7f0ffeffec7d0864eb8855fe8e873743> {
internal static readonly GlobalObjectKey IdOrderDetail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*__4Pf33sZAjriFX+joc3Qw");

public EN_26f696e758428762fc617e811634d15dEntityRecord ssENOrderDetail;


public static implicit operator EN_26f696e758428762fc617e811634d15dEntityRecord( RC_7f0ffeffec7d0864eb8855fe8e873743 r) {
return r.ssENOrderDetail;
}

public static implicit operator RC_7f0ffeffec7d0864eb8855fe8e873743 (EN_26f696e758428762fc617e811634d15dEntityRecord r) {
RC_7f0ffeffec7d0864eb8855fe8e873743 res = new RC_7f0ffeffec7d0864eb8855fe8e873743 ();
res.ssENOrderDetail = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderDetail.ChangedAttributes = value;
}
get {
    return ssENOrderDetail.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_7f0ffeffec7d0864eb8855fe8e873743() {
OptimizedAttributes = null;
ssENOrderDetail = new EN_26f696e758428762fc617e811634d15dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(39,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderDetail.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderDetail.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderDetail.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderDetail.Read( r, ref index);
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
public void ReadIM(RC_7f0ffeffec7d0864eb8855fe8e873743 r) {
this = r;
}


public static bool operator == (RC_7f0ffeffec7d0864eb8855fe8e873743 a, RC_7f0ffeffec7d0864eb8855fe8e873743 b) {
if (a.ssENOrderDetail != b.ssENOrderDetail) return false;
return true;
}

public static bool operator != (RC_7f0ffeffec7d0864eb8855fe8e873743 a, RC_7f0ffeffec7d0864eb8855fe8e873743 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7f0ffeffec7d0864eb8855fe8e873743)) return false;
return (this == (RC_7f0ffeffec7d0864eb8855fe8e873743)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderDetail.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderDetail.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderDetail.InternalRecursiveSave();
}


public RC_7f0ffeffec7d0864eb8855fe8e873743 Duplicate() {
RC_7f0ffeffec7d0864eb8855fe8e873743 t;
t.ssENOrderDetail = (EN_26f696e758428762fc617e811634d15dEntityRecord)this.ssENOrderDetail.Duplicate();
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
if (head == "orderdetail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDetail")) variable.Value = ssENOrderDetail; else variable.Optimized = true;
variable.SetFieldName("orderdetail");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderDetail.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderDetail.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderDetail) {
return ssENOrderDetail;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderDetail.Key.AsGuid) {
return ssENOrderDetail;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderDetail.FillFromOther((IRecord) other.AttributeGet(IdOrderDetail));
}
} // RC_7f0ffeffec7d0864eb8855fe8e873743
/// <summary>
/// RecordList type <code>OrderDetailRecordList</code> that represents a record list of
///  <code>OrderDetail</code>
/// </summary>
public partial class RL_e5767287da79a139581b76b6fbb20753 : GenericRecordList<RC_7f0ffeffec7d0864eb8855fe8e873743>, IEnumerable, IEnumerator {

protected override RC_7f0ffeffec7d0864eb8855fe8e873743 GetElementDefaultValue() {
return new RC_7f0ffeffec7d0864eb8855fe8e873743();
}

public T[] ToArray<T>(Func<RC_7f0ffeffec7d0864eb8855fe8e873743, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e5767287da79a139581b76b6fbb20753 recordList, Func<RC_7f0ffeffec7d0864eb8855fe8e873743, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e5767287da79a139581b76b6fbb20753(RC_7f0ffeffec7d0864eb8855fe8e873743[] array) {
  RL_e5767287da79a139581b76b6fbb20753 result = new RL_e5767287da79a139581b76b6fbb20753();
result.InnerFromArray(array);
    return result;
}

public static RL_e5767287da79a139581b76b6fbb20753 ToList<T>(T[] array, Func <T, RC_7f0ffeffec7d0864eb8855fe8e873743> converter) {
  RL_e5767287da79a139581b76b6fbb20753 result = new RL_e5767287da79a139581b76b6fbb20753();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e5767287da79a139581b76b6fbb20753 FromRestList<T>(RestList<T> restList, Func <T, RC_7f0ffeffec7d0864eb8855fe8e873743> converter) {
  RL_e5767287da79a139581b76b6fbb20753 result = new RL_e5767287da79a139581b76b6fbb20753();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e5767287da79a139581b76b6fbb20753() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(39,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7f0ffeffec7d0864eb8855fe8e873743> NewList() {
return new RL_e5767287da79a139581b76b6fbb20753();
}


} // RL_e5767287da79a139581b76b6fbb20753
}

