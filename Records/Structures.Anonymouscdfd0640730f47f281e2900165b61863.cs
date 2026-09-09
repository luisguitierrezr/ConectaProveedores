namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (QAb9zQ9z8keB4pABZbYYYw)
///  <code>RC_485b607178d0c84cbed628be5b894f6f</code> that represents <code>ActionResultRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ActionResultRecord
public partial struct RC_485b607178d0c84cbed628be5b894f6f : ITypedRecord<RC_485b607178d0c84cbed628be5b894f6f> {
internal static readonly GlobalObjectKey IdActionResult = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*cWBbSNB4TMi+1ii+W4lPbw");

public ST_9f3831cec6ebd34416b59b8df7a27893Structure ssSTActionResult;


public static implicit operator ST_9f3831cec6ebd34416b59b8df7a27893Structure( RC_485b607178d0c84cbed628be5b894f6f r) {
return r.ssSTActionResult;
}

public static implicit operator RC_485b607178d0c84cbed628be5b894f6f (ST_9f3831cec6ebd34416b59b8df7a27893Structure r) {
RC_485b607178d0c84cbed628be5b894f6f res = new RC_485b607178d0c84cbed628be5b894f6f ();
res.ssSTActionResult = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_485b607178d0c84cbed628be5b894f6f() {
OptimizedAttributes = null;
ssSTActionResult = new ST_9f3831cec6ebd34416b59b8df7a27893Structure();
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
    ssSTActionResult.OptimizedAttributes = value[0];
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
ssSTActionResult.Read( r, ref index);
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
public void ReadIM(RC_485b607178d0c84cbed628be5b894f6f r) {
this = r;
}


public static bool operator == (RC_485b607178d0c84cbed628be5b894f6f a, RC_485b607178d0c84cbed628be5b894f6f b) {
if (a.ssSTActionResult != b.ssSTActionResult) return false;
return true;
}

public static bool operator != (RC_485b607178d0c84cbed628be5b894f6f a, RC_485b607178d0c84cbed628be5b894f6f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_485b607178d0c84cbed628be5b894f6f)) return false;
return (this == (RC_485b607178d0c84cbed628be5b894f6f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTActionResult.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTActionResult.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTActionResult.InternalRecursiveSave();
}


public RC_485b607178d0c84cbed628be5b894f6f Duplicate() {
RC_485b607178d0c84cbed628be5b894f6f t;
t.ssSTActionResult = (ST_9f3831cec6ebd34416b59b8df7a27893Structure)this.ssSTActionResult.Duplicate();
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
if (head == "actionresult") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ActionResult")) variable.Value = ssSTActionResult; else variable.Optimized = true;
variable.SetFieldName("actionresult");
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
if (key == IdActionResult) {
return ssSTActionResult;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdActionResult.Key.AsGuid) {
return ssSTActionResult;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTActionResult.FillFromOther((IRecord) other.AttributeGet(IdActionResult));
}
} // RC_485b607178d0c84cbed628be5b894f6f
/// <summary>
/// RecordList type <code>ActionResultRecordList</code> that represents a record list of
///  <code>ActionResult</code>
/// </summary>
public partial class RL_a4e0198803e5c63592da2cbbb4d058ad : GenericRecordList<RC_485b607178d0c84cbed628be5b894f6f>, IEnumerable, IEnumerator {

protected override RC_485b607178d0c84cbed628be5b894f6f GetElementDefaultValue() {
return new RC_485b607178d0c84cbed628be5b894f6f();
}

public T[] ToArray<T>(Func<RC_485b607178d0c84cbed628be5b894f6f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a4e0198803e5c63592da2cbbb4d058ad recordList, Func<RC_485b607178d0c84cbed628be5b894f6f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a4e0198803e5c63592da2cbbb4d058ad(RC_485b607178d0c84cbed628be5b894f6f[] array) {
  RL_a4e0198803e5c63592da2cbbb4d058ad result = new RL_a4e0198803e5c63592da2cbbb4d058ad();
result.InnerFromArray(array);
    return result;
}

public static RL_a4e0198803e5c63592da2cbbb4d058ad ToList<T>(T[] array, Func <T, RC_485b607178d0c84cbed628be5b894f6f> converter) {
  RL_a4e0198803e5c63592da2cbbb4d058ad result = new RL_a4e0198803e5c63592da2cbbb4d058ad();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a4e0198803e5c63592da2cbbb4d058ad FromRestList<T>(RestList<T> restList, Func <T, RC_485b607178d0c84cbed628be5b894f6f> converter) {
  RL_a4e0198803e5c63592da2cbbb4d058ad result = new RL_a4e0198803e5c63592da2cbbb4d058ad();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a4e0198803e5c63592da2cbbb4d058ad() : base() {
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
protected override OSList<RC_485b607178d0c84cbed628be5b894f6f> NewList() {
return new RL_a4e0198803e5c63592da2cbbb4d058ad();
}


} // RL_a4e0198803e5c63592da2cbbb4d058ad
}

