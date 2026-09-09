namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (waZOb5pSGECoOwXHeDKoEg)
///  <code>RC_28bce23859a55ab059649bad680a14c2</code> that represents <code>PI_HEADER5Record</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_HEADER5Record
public partial struct RC_28bce23859a55ab059649bad680a14c2 : ITypedRecord<RC_28bce23859a55ab059649bad680a14c2> {
internal static readonly GlobalObjectKey IdPI_HEADER5 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OOK8KKVZsFpZZJutaAoUwg");

public ST_976925bffb49d1800d61d6274bd325dfStructure ssSTPI_HEADER5;


public static implicit operator ST_976925bffb49d1800d61d6274bd325dfStructure( RC_28bce23859a55ab059649bad680a14c2 r) {
return r.ssSTPI_HEADER5;
}

public static implicit operator RC_28bce23859a55ab059649bad680a14c2 (ST_976925bffb49d1800d61d6274bd325dfStructure r) {
RC_28bce23859a55ab059649bad680a14c2 res = new RC_28bce23859a55ab059649bad680a14c2 ();
res.ssSTPI_HEADER5 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_28bce23859a55ab059649bad680a14c2() {
OptimizedAttributes = null;
ssSTPI_HEADER5 = new ST_976925bffb49d1800d61d6274bd325dfStructure();
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
    ssSTPI_HEADER5.OptimizedAttributes = value[0];
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
ssSTPI_HEADER5.Read( r, ref index);
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
public void ReadIM(RC_28bce23859a55ab059649bad680a14c2 r) {
this = r;
}


public static bool operator == (RC_28bce23859a55ab059649bad680a14c2 a, RC_28bce23859a55ab059649bad680a14c2 b) {
if (a.ssSTPI_HEADER5 != b.ssSTPI_HEADER5) return false;
return true;
}

public static bool operator != (RC_28bce23859a55ab059649bad680a14c2 a, RC_28bce23859a55ab059649bad680a14c2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_28bce23859a55ab059649bad680a14c2)) return false;
return (this == (RC_28bce23859a55ab059649bad680a14c2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_HEADER5.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_HEADER5.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_HEADER5.InternalRecursiveSave();
}


public RC_28bce23859a55ab059649bad680a14c2 Duplicate() {
RC_28bce23859a55ab059649bad680a14c2 t;
t.ssSTPI_HEADER5 = (ST_976925bffb49d1800d61d6274bd325dfStructure)this.ssSTPI_HEADER5.Duplicate();
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
if (head == "pi_header5") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_HEADER5")) variable.Value = ssSTPI_HEADER5; else variable.Optimized = true;
variable.SetFieldName("pi_header5");
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
if (key == IdPI_HEADER5) {
return ssSTPI_HEADER5;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_HEADER5.Key.AsGuid) {
return ssSTPI_HEADER5;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_HEADER5.FillFromOther((IRecord) other.AttributeGet(IdPI_HEADER5));
}
} // RC_28bce23859a55ab059649bad680a14c2
/// <summary>
/// RecordList type <code>PI_HEADER5RecordList</code> that represents a record list of
///  <code>PI_HEADER5</code>
/// </summary>
public partial class RL_e55a34412fc89f0feaf33a15131d0f4a : GenericRecordList<RC_28bce23859a55ab059649bad680a14c2>, IEnumerable, IEnumerator {

protected override RC_28bce23859a55ab059649bad680a14c2 GetElementDefaultValue() {
return new RC_28bce23859a55ab059649bad680a14c2();
}

public T[] ToArray<T>(Func<RC_28bce23859a55ab059649bad680a14c2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e55a34412fc89f0feaf33a15131d0f4a recordList, Func<RC_28bce23859a55ab059649bad680a14c2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e55a34412fc89f0feaf33a15131d0f4a(RC_28bce23859a55ab059649bad680a14c2[] array) {
  RL_e55a34412fc89f0feaf33a15131d0f4a result = new RL_e55a34412fc89f0feaf33a15131d0f4a();
result.InnerFromArray(array);
    return result;
}

public static RL_e55a34412fc89f0feaf33a15131d0f4a ToList<T>(T[] array, Func <T, RC_28bce23859a55ab059649bad680a14c2> converter) {
  RL_e55a34412fc89f0feaf33a15131d0f4a result = new RL_e55a34412fc89f0feaf33a15131d0f4a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e55a34412fc89f0feaf33a15131d0f4a FromRestList<T>(RestList<T> restList, Func <T, RC_28bce23859a55ab059649bad680a14c2> converter) {
  RL_e55a34412fc89f0feaf33a15131d0f4a result = new RL_e55a34412fc89f0feaf33a15131d0f4a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e55a34412fc89f0feaf33a15131d0f4a() : base() {
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
protected override OSList<RC_28bce23859a55ab059649bad680a14c2> NewList() {
return new RL_e55a34412fc89f0feaf33a15131d0f4a();
}


} // RL_e55a34412fc89f0feaf33a15131d0f4a
}

