namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (cfN6r_kXdkiFJb3_Qpabjw)
///  <code>RC_221a79ae57c7b1d18e3f1435bcd9694b</code> that represent
/// s <code>DocumentExtrationDateRangeRecord</code> <p>Description: </p>
/// </summary>
// Name: DocumentExtrationDateRangeRecord
public partial struct RC_221a79ae57c7b1d18e3f1435bcd9694b : ITypedRecord<RC_221a79ae57c7b1d18e3f1435bcd9694b> {
internal static readonly GlobalObjectKey IdDocumentExtrationDateRange = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rnkaIsdX0bGOPxQ1vNlpSw");

public ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure ssSTDocumentExtrationDateRange;


public static implicit operator ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure( RC_221a79ae57c7b1d18e3f1435bcd9694b r) {
return r.ssSTDocumentExtrationDateRange;
}

public static implicit operator RC_221a79ae57c7b1d18e3f1435bcd9694b (ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure r) {
RC_221a79ae57c7b1d18e3f1435bcd9694b res = new RC_221a79ae57c7b1d18e3f1435bcd9694b ();
res.ssSTDocumentExtrationDateRange = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_221a79ae57c7b1d18e3f1435bcd9694b() {
OptimizedAttributes = null;
ssSTDocumentExtrationDateRange = new ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTDocumentExtrationDateRange.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTDocumentExtrationDateRange.Read( r, ref index);
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
public void ReadIM(RC_221a79ae57c7b1d18e3f1435bcd9694b r) {
this = r;
}


public static bool operator == (RC_221a79ae57c7b1d18e3f1435bcd9694b a, RC_221a79ae57c7b1d18e3f1435bcd9694b b) {
if (a.ssSTDocumentExtrationDateRange != b.ssSTDocumentExtrationDateRange) return false;
return true;
}

public static bool operator != (RC_221a79ae57c7b1d18e3f1435bcd9694b a, RC_221a79ae57c7b1d18e3f1435bcd9694b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_221a79ae57c7b1d18e3f1435bcd9694b)) return false;
return (this == (RC_221a79ae57c7b1d18e3f1435bcd9694b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDocumentExtrationDateRange.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDocumentExtrationDateRange.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDocumentExtrationDateRange.InternalRecursiveSave();
}


public RC_221a79ae57c7b1d18e3f1435bcd9694b Duplicate() {
RC_221a79ae57c7b1d18e3f1435bcd9694b t;
t.ssSTDocumentExtrationDateRange = (ST_f7dffde36d596dbbfeff3dd3ce2ebeadStructure)this.ssSTDocumentExtrationDateRange.Duplicate();
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
if (head == "documentextrationdaterange") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentExtrationDateRange")) variable.Value = ssSTDocumentExtrationDateRange; else variable.Optimized = true;
variable.SetFieldName("documentextrationdaterange");
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
if (key == IdDocumentExtrationDateRange) {
return ssSTDocumentExtrationDateRange;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDocumentExtrationDateRange.Key.AsGuid) {
return ssSTDocumentExtrationDateRange;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDocumentExtrationDateRange.FillFromOther((IRecord) other.AttributeGet(IdDocumentExtrationDateRange));
}
} // RC_221a79ae57c7b1d18e3f1435bcd9694b
/// <summary>
/// RecordList type <code>DocumentExtrationDateRangeRecordList</code> that represents a record list of
///  <code>DocumentExtrationDateRange</code>
/// </summary>
public partial class RL_2b2250dae3adb3f820f24fa2783032d4 : GenericRecordList<RC_221a79ae57c7b1d18e3f1435bcd9694b>, IEnumerable, IEnumerator {

protected override RC_221a79ae57c7b1d18e3f1435bcd9694b GetElementDefaultValue() {
return new RC_221a79ae57c7b1d18e3f1435bcd9694b();
}

public T[] ToArray<T>(Func<RC_221a79ae57c7b1d18e3f1435bcd9694b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2b2250dae3adb3f820f24fa2783032d4 recordList, Func<RC_221a79ae57c7b1d18e3f1435bcd9694b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2b2250dae3adb3f820f24fa2783032d4(RC_221a79ae57c7b1d18e3f1435bcd9694b[] array) {
  RL_2b2250dae3adb3f820f24fa2783032d4 result = new RL_2b2250dae3adb3f820f24fa2783032d4();
result.InnerFromArray(array);
    return result;
}

public static RL_2b2250dae3adb3f820f24fa2783032d4 ToList<T>(T[] array, Func <T, RC_221a79ae57c7b1d18e3f1435bcd9694b> converter) {
  RL_2b2250dae3adb3f820f24fa2783032d4 result = new RL_2b2250dae3adb3f820f24fa2783032d4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2b2250dae3adb3f820f24fa2783032d4 FromRestList<T>(RestList<T> restList, Func <T, RC_221a79ae57c7b1d18e3f1435bcd9694b> converter) {
  RL_2b2250dae3adb3f820f24fa2783032d4 result = new RL_2b2250dae3adb3f820f24fa2783032d4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2b2250dae3adb3f820f24fa2783032d4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_221a79ae57c7b1d18e3f1435bcd9694b> NewList() {
return new RL_2b2250dae3adb3f820f24fa2783032d4();
}


} // RL_2b2250dae3adb3f820f24fa2783032d4
}

