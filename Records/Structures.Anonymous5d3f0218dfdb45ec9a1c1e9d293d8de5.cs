namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (GAI_Xdvf7EWaHB6dKT2N5Q)
///  <code>RC_b0a85cd983a4f43fec20a9e94774104b</code> that represent
/// s <code>RequisitionStatusRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionStatusRecord
public partial struct RC_b0a85cd983a4f43fec20a9e94774104b : ITypedRecord<RC_b0a85cd983a4f43fec20a9e94774104b> {
internal static readonly GlobalObjectKey IdRequisitionStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2VyosKSDP_TsIKnpR3QQSw");

public EN_0554a1252840ba4a5c4e6af5899608adEntityRecord ssENRequisitionStatus;


public static implicit operator EN_0554a1252840ba4a5c4e6af5899608adEntityRecord( RC_b0a85cd983a4f43fec20a9e94774104b r) {
return r.ssENRequisitionStatus;
}

public static implicit operator RC_b0a85cd983a4f43fec20a9e94774104b (EN_0554a1252840ba4a5c4e6af5899608adEntityRecord r) {
RC_b0a85cd983a4f43fec20a9e94774104b res = new RC_b0a85cd983a4f43fec20a9e94774104b ();
res.ssENRequisitionStatus = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRequisitionStatus.ChangedAttributes = value;
}
get {
    return ssENRequisitionStatus.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_b0a85cd983a4f43fec20a9e94774104b() {
OptimizedAttributes = null;
ssENRequisitionStatus = new EN_0554a1252840ba4a5c4e6af5899608adEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRequisitionStatus.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRequisitionStatus.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisitionStatus.Read( r, ref index);
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
public void ReadIM(RC_b0a85cd983a4f43fec20a9e94774104b r) {
this = r;
}


public static bool operator == (RC_b0a85cd983a4f43fec20a9e94774104b a, RC_b0a85cd983a4f43fec20a9e94774104b b) {
if (a.ssENRequisitionStatus != b.ssENRequisitionStatus) return false;
return true;
}

public static bool operator != (RC_b0a85cd983a4f43fec20a9e94774104b a, RC_b0a85cd983a4f43fec20a9e94774104b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b0a85cd983a4f43fec20a9e94774104b)) return false;
return (this == (RC_b0a85cd983a4f43fec20a9e94774104b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionStatus.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionStatus.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionStatus.InternalRecursiveSave();
}


public RC_b0a85cd983a4f43fec20a9e94774104b Duplicate() {
RC_b0a85cd983a4f43fec20a9e94774104b t;
t.ssENRequisitionStatus = (EN_0554a1252840ba4a5c4e6af5899608adEntityRecord)this.ssENRequisitionStatus.Duplicate();
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
if (head == "requisitionstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionStatus")) variable.Value = ssENRequisitionStatus; else variable.Optimized = true;
variable.SetFieldName("requisitionstatus");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionStatus.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionStatus.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRequisitionStatus) {
return ssENRequisitionStatus;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionStatus.Key.AsGuid) {
return ssENRequisitionStatus;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionStatus.FillFromOther((IRecord) other.AttributeGet(IdRequisitionStatus));
}
} // RC_b0a85cd983a4f43fec20a9e94774104b
/// <summary>
/// RecordList type <code>RequisitionStatusRecordList</code> that represents a record list of
///  <code>RequisitionStatus</code>
/// </summary>
public partial class RL_7324330f004cfb528140f21030a5e90f : GenericRecordList<RC_b0a85cd983a4f43fec20a9e94774104b>, IEnumerable, IEnumerator {

protected override RC_b0a85cd983a4f43fec20a9e94774104b GetElementDefaultValue() {
return new RC_b0a85cd983a4f43fec20a9e94774104b();
}

public T[] ToArray<T>(Func<RC_b0a85cd983a4f43fec20a9e94774104b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7324330f004cfb528140f21030a5e90f recordList, Func<RC_b0a85cd983a4f43fec20a9e94774104b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7324330f004cfb528140f21030a5e90f(RC_b0a85cd983a4f43fec20a9e94774104b[] array) {
  RL_7324330f004cfb528140f21030a5e90f result = new RL_7324330f004cfb528140f21030a5e90f();
result.InnerFromArray(array);
    return result;
}

public static RL_7324330f004cfb528140f21030a5e90f ToList<T>(T[] array, Func <T, RC_b0a85cd983a4f43fec20a9e94774104b> converter) {
  RL_7324330f004cfb528140f21030a5e90f result = new RL_7324330f004cfb528140f21030a5e90f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7324330f004cfb528140f21030a5e90f FromRestList<T>(RestList<T> restList, Func <T, RC_b0a85cd983a4f43fec20a9e94774104b> converter) {
  RL_7324330f004cfb528140f21030a5e90f result = new RL_7324330f004cfb528140f21030a5e90f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7324330f004cfb528140f21030a5e90f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b0a85cd983a4f43fec20a9e94774104b> NewList() {
return new RL_7324330f004cfb528140f21030a5e90f();
}


} // RL_7324330f004cfb528140f21030a5e90f
}

