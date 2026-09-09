namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (UZq_sXzAD0uL7gwEx4Nwuw)
///  <code>RC_896ad3137023f533323e3fc3a800f331</code> that represents <code>SubdirectionRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: SubdirectionRecord
public partial struct RC_896ad3137023f533323e3fc3a800f331 : ITypedRecord<RC_896ad3137023f533323e3fc3a800f331> {
internal static readonly GlobalObjectKey IdSubdirection = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*E9NqiSNwM_UyPj_DqADzMQ");

public EN_f6a1d672e0d5a13856fcddfe60f7e1e8EntityRecord ssENSubdirection;


public static implicit operator EN_f6a1d672e0d5a13856fcddfe60f7e1e8EntityRecord( RC_896ad3137023f533323e3fc3a800f331 r) {
return r.ssENSubdirection;
}

public static implicit operator RC_896ad3137023f533323e3fc3a800f331 (EN_f6a1d672e0d5a13856fcddfe60f7e1e8EntityRecord r) {
RC_896ad3137023f533323e3fc3a800f331 res = new RC_896ad3137023f533323e3fc3a800f331 ();
res.ssENSubdirection = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSubdirection.ChangedAttributes = value;
}
get {
    return ssENSubdirection.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_896ad3137023f533323e3fc3a800f331() {
OptimizedAttributes = null;
ssENSubdirection = new EN_f6a1d672e0d5a13856fcddfe60f7e1e8EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSubdirection.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSubdirection.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSubdirection.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSubdirection.Read( r, ref index);
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
public void ReadIM(RC_896ad3137023f533323e3fc3a800f331 r) {
this = r;
}


public static bool operator == (RC_896ad3137023f533323e3fc3a800f331 a, RC_896ad3137023f533323e3fc3a800f331 b) {
if (a.ssENSubdirection != b.ssENSubdirection) return false;
return true;
}

public static bool operator != (RC_896ad3137023f533323e3fc3a800f331 a, RC_896ad3137023f533323e3fc3a800f331 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_896ad3137023f533323e3fc3a800f331)) return false;
return (this == (RC_896ad3137023f533323e3fc3a800f331)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSubdirection.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSubdirection.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSubdirection.InternalRecursiveSave();
}


public RC_896ad3137023f533323e3fc3a800f331 Duplicate() {
RC_896ad3137023f533323e3fc3a800f331 t;
t.ssENSubdirection = (EN_f6a1d672e0d5a13856fcddfe60f7e1e8EntityRecord)this.ssENSubdirection.Duplicate();
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
if (head == "subdirection") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Subdirection")) variable.Value = ssENSubdirection; else variable.Optimized = true;
variable.SetFieldName("subdirection");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSubdirection.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSubdirection.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSubdirection) {
return ssENSubdirection;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSubdirection.Key.AsGuid) {
return ssENSubdirection;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSubdirection.FillFromOther((IRecord) other.AttributeGet(IdSubdirection));
}
} // RC_896ad3137023f533323e3fc3a800f331
/// <summary>
/// RecordList type <code>SubdirectionRecordList</code> that represents a record list of
///  <code>Subdirection</code>
/// </summary>
public partial class RL_58a9989a5804b0fa48641152a7ea7fb4 : GenericRecordList<RC_896ad3137023f533323e3fc3a800f331>, IEnumerable, IEnumerator {

protected override RC_896ad3137023f533323e3fc3a800f331 GetElementDefaultValue() {
return new RC_896ad3137023f533323e3fc3a800f331();
}

public T[] ToArray<T>(Func<RC_896ad3137023f533323e3fc3a800f331, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_58a9989a5804b0fa48641152a7ea7fb4 recordList, Func<RC_896ad3137023f533323e3fc3a800f331, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_58a9989a5804b0fa48641152a7ea7fb4(RC_896ad3137023f533323e3fc3a800f331[] array) {
  RL_58a9989a5804b0fa48641152a7ea7fb4 result = new RL_58a9989a5804b0fa48641152a7ea7fb4();
result.InnerFromArray(array);
    return result;
}

public static RL_58a9989a5804b0fa48641152a7ea7fb4 ToList<T>(T[] array, Func <T, RC_896ad3137023f533323e3fc3a800f331> converter) {
  RL_58a9989a5804b0fa48641152a7ea7fb4 result = new RL_58a9989a5804b0fa48641152a7ea7fb4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_58a9989a5804b0fa48641152a7ea7fb4 FromRestList<T>(RestList<T> restList, Func <T, RC_896ad3137023f533323e3fc3a800f331> converter) {
  RL_58a9989a5804b0fa48641152a7ea7fb4 result = new RL_58a9989a5804b0fa48641152a7ea7fb4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_58a9989a5804b0fa48641152a7ea7fb4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_896ad3137023f533323e3fc3a800f331> NewList() {
return new RL_58a9989a5804b0fa48641152a7ea7fb4();
}


} // RL_58a9989a5804b0fa48641152a7ea7fb4
}

