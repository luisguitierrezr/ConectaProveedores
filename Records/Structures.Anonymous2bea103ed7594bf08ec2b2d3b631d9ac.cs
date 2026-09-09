namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (PhDqK1nX8EuOwrLTtjHZrA)
///  <code>RC_6328ceb8eefbea788ac97a92ce1c3549</code> that represents <code>OrderResultRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OrderResultRecord
public partial struct RC_6328ceb8eefbea788ac97a92ce1c3549 : ITypedRecord<RC_6328ceb8eefbea788ac97a92ce1c3549> {
internal static readonly GlobalObjectKey IdOrderResult = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uM4oY_vueOqKyXqSzhw1SQ");

public ST_5a17d82af8397abda9cf3915ce9c082fStructure ssSTOrderResult;


public static implicit operator ST_5a17d82af8397abda9cf3915ce9c082fStructure( RC_6328ceb8eefbea788ac97a92ce1c3549 r) {
return r.ssSTOrderResult;
}

public static implicit operator RC_6328ceb8eefbea788ac97a92ce1c3549 (ST_5a17d82af8397abda9cf3915ce9c082fStructure r) {
RC_6328ceb8eefbea788ac97a92ce1c3549 res = new RC_6328ceb8eefbea788ac97a92ce1c3549 ();
res.ssSTOrderResult = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_6328ceb8eefbea788ac97a92ce1c3549() {
OptimizedAttributes = null;
ssSTOrderResult = new ST_5a17d82af8397abda9cf3915ce9c082fStructure();
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
    ssSTOrderResult.OptimizedAttributes = value[0];
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
ssSTOrderResult.Read( r, ref index);
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
public void ReadIM(RC_6328ceb8eefbea788ac97a92ce1c3549 r) {
this = r;
}


public static bool operator == (RC_6328ceb8eefbea788ac97a92ce1c3549 a, RC_6328ceb8eefbea788ac97a92ce1c3549 b) {
if (a.ssSTOrderResult != b.ssSTOrderResult) return false;
return true;
}

public static bool operator != (RC_6328ceb8eefbea788ac97a92ce1c3549 a, RC_6328ceb8eefbea788ac97a92ce1c3549 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6328ceb8eefbea788ac97a92ce1c3549)) return false;
return (this == (RC_6328ceb8eefbea788ac97a92ce1c3549)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOrderResult.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOrderResult.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOrderResult.InternalRecursiveSave();
}


public RC_6328ceb8eefbea788ac97a92ce1c3549 Duplicate() {
RC_6328ceb8eefbea788ac97a92ce1c3549 t;
t.ssSTOrderResult = (ST_5a17d82af8397abda9cf3915ce9c082fStructure)this.ssSTOrderResult.Duplicate();
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
if (head == "orderresult") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderResult")) variable.Value = ssSTOrderResult; else variable.Optimized = true;
variable.SetFieldName("orderresult");
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
if (key == IdOrderResult) {
return ssSTOrderResult;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderResult.Key.AsGuid) {
return ssSTOrderResult;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOrderResult.FillFromOther((IRecord) other.AttributeGet(IdOrderResult));
}
} // RC_6328ceb8eefbea788ac97a92ce1c3549
/// <summary>
/// RecordList type <code>OrderResultRecordList</code> that represents a record list of
///  <code>OrderResult</code>
/// </summary>
public partial class RL_2e6d403ee13af355fc04fd414456539a : GenericRecordList<RC_6328ceb8eefbea788ac97a92ce1c3549>, IEnumerable, IEnumerator {

protected override RC_6328ceb8eefbea788ac97a92ce1c3549 GetElementDefaultValue() {
return new RC_6328ceb8eefbea788ac97a92ce1c3549();
}

public T[] ToArray<T>(Func<RC_6328ceb8eefbea788ac97a92ce1c3549, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2e6d403ee13af355fc04fd414456539a recordList, Func<RC_6328ceb8eefbea788ac97a92ce1c3549, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2e6d403ee13af355fc04fd414456539a(RC_6328ceb8eefbea788ac97a92ce1c3549[] array) {
  RL_2e6d403ee13af355fc04fd414456539a result = new RL_2e6d403ee13af355fc04fd414456539a();
result.InnerFromArray(array);
    return result;
}

public static RL_2e6d403ee13af355fc04fd414456539a ToList<T>(T[] array, Func <T, RC_6328ceb8eefbea788ac97a92ce1c3549> converter) {
  RL_2e6d403ee13af355fc04fd414456539a result = new RL_2e6d403ee13af355fc04fd414456539a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2e6d403ee13af355fc04fd414456539a FromRestList<T>(RestList<T> restList, Func <T, RC_6328ceb8eefbea788ac97a92ce1c3549> converter) {
  RL_2e6d403ee13af355fc04fd414456539a result = new RL_2e6d403ee13af355fc04fd414456539a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2e6d403ee13af355fc04fd414456539a() : base() {
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
protected override OSList<RC_6328ceb8eefbea788ac97a92ce1c3549> NewList() {
return new RL_2e6d403ee13af355fc04fd414456539a();
}


} // RL_2e6d403ee13af355fc04fd414456539a
}

