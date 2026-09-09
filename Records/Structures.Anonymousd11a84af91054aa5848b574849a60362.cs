namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (r4Qa0QWRpUqEi1dISaYDYg)
///  <code>RC_ff8382bb6fb6cc7d57ecda7bb499922f</code> that represent
/// s <code>OrderApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderApprovalLevelRecord
public partial struct RC_ff8382bb6fb6cc7d57ecda7bb499922f : ITypedRecord<RC_ff8382bb6fb6cc7d57ecda7bb499922f> {
internal static readonly GlobalObjectKey IdOrderApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*u4KD_7ZvfcxX7Np7tJmSLw");

public EN_6b660d05e4c0025dff47119642875ca2EntityRecord ssENOrderApprovalLevel;


public static implicit operator EN_6b660d05e4c0025dff47119642875ca2EntityRecord( RC_ff8382bb6fb6cc7d57ecda7bb499922f r) {
return r.ssENOrderApprovalLevel;
}

public static implicit operator RC_ff8382bb6fb6cc7d57ecda7bb499922f (EN_6b660d05e4c0025dff47119642875ca2EntityRecord r) {
RC_ff8382bb6fb6cc7d57ecda7bb499922f res = new RC_ff8382bb6fb6cc7d57ecda7bb499922f ();
res.ssENOrderApprovalLevel = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderApprovalLevel.ChangedAttributes = value;
}
get {
    return ssENOrderApprovalLevel.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_ff8382bb6fb6cc7d57ecda7bb499922f() {
OptimizedAttributes = null;
ssENOrderApprovalLevel = new EN_6b660d05e4c0025dff47119642875ca2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(17,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderApprovalLevel.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderApprovalLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
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
public void ReadIM(RC_ff8382bb6fb6cc7d57ecda7bb499922f r) {
this = r;
}


public static bool operator == (RC_ff8382bb6fb6cc7d57ecda7bb499922f a, RC_ff8382bb6fb6cc7d57ecda7bb499922f b) {
if (a.ssENOrderApprovalLevel != b.ssENOrderApprovalLevel) return false;
return true;
}

public static bool operator != (RC_ff8382bb6fb6cc7d57ecda7bb499922f a, RC_ff8382bb6fb6cc7d57ecda7bb499922f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ff8382bb6fb6cc7d57ecda7bb499922f)) return false;
return (this == (RC_ff8382bb6fb6cc7d57ecda7bb499922f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderApprovalLevel.InternalRecursiveSave();
}


public RC_ff8382bb6fb6cc7d57ecda7bb499922f Duplicate() {
RC_ff8382bb6fb6cc7d57ecda7bb499922f t;
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
if (head == "orderapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApprovalLevel")) variable.Value = ssENOrderApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("orderapprovallevel");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderApprovalLevel.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderApprovalLevel.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderApprovalLevel) {
return ssENOrderApprovalLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderApprovalLevel.Key.AsGuid) {
return ssENOrderApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdOrderApprovalLevel));
}
} // RC_ff8382bb6fb6cc7d57ecda7bb499922f
/// <summary>
/// RecordList type <code>OrderApprovalLevelRecordList</code> that represents a record list of
///  <code>OrderApprovalLevel</code>
/// </summary>
public partial class RL_ee0c9b1586585bb225d3aea45637d365 : GenericRecordList<RC_ff8382bb6fb6cc7d57ecda7bb499922f>, IEnumerable, IEnumerator {

protected override RC_ff8382bb6fb6cc7d57ecda7bb499922f GetElementDefaultValue() {
return new RC_ff8382bb6fb6cc7d57ecda7bb499922f();
}

public T[] ToArray<T>(Func<RC_ff8382bb6fb6cc7d57ecda7bb499922f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ee0c9b1586585bb225d3aea45637d365 recordList, Func<RC_ff8382bb6fb6cc7d57ecda7bb499922f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ee0c9b1586585bb225d3aea45637d365(RC_ff8382bb6fb6cc7d57ecda7bb499922f[] array) {
  RL_ee0c9b1586585bb225d3aea45637d365 result = new RL_ee0c9b1586585bb225d3aea45637d365();
result.InnerFromArray(array);
    return result;
}

public static RL_ee0c9b1586585bb225d3aea45637d365 ToList<T>(T[] array, Func <T, RC_ff8382bb6fb6cc7d57ecda7bb499922f> converter) {
  RL_ee0c9b1586585bb225d3aea45637d365 result = new RL_ee0c9b1586585bb225d3aea45637d365();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ee0c9b1586585bb225d3aea45637d365 FromRestList<T>(RestList<T> restList, Func <T, RC_ff8382bb6fb6cc7d57ecda7bb499922f> converter) {
  RL_ee0c9b1586585bb225d3aea45637d365 result = new RL_ee0c9b1586585bb225d3aea45637d365();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ee0c9b1586585bb225d3aea45637d365() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(17,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ff8382bb6fb6cc7d57ecda7bb499922f> NewList() {
return new RL_ee0c9b1586585bb225d3aea45637d365();
}


} // RL_ee0c9b1586585bb225d3aea45637d365
}

