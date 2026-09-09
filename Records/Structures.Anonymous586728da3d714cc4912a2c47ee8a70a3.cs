namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (2ihnWHE9xEyRKixH7opwow)
///  <code>RC_572f32750027334be4afde2b8efad62f</code> that represents <code>PI_HEADER2Record</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_HEADER2Record
public partial struct RC_572f32750027334be4afde2b8efad62f : ITypedRecord<RC_572f32750027334be4afde2b8efad62f> {
internal static readonly GlobalObjectKey IdPI_HEADER2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dTIvVycASzPkr94rjvrWLw");

public ST_af46d22a4ab690d6a003acf927bb2771Structure ssSTPI_HEADER2;


public static implicit operator ST_af46d22a4ab690d6a003acf927bb2771Structure( RC_572f32750027334be4afde2b8efad62f r) {
return r.ssSTPI_HEADER2;
}

public static implicit operator RC_572f32750027334be4afde2b8efad62f (ST_af46d22a4ab690d6a003acf927bb2771Structure r) {
RC_572f32750027334be4afde2b8efad62f res = new RC_572f32750027334be4afde2b8efad62f ();
res.ssSTPI_HEADER2 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_572f32750027334be4afde2b8efad62f() {
OptimizedAttributes = null;
ssSTPI_HEADER2 = new ST_af46d22a4ab690d6a003acf927bb2771Structure();
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
    ssSTPI_HEADER2.OptimizedAttributes = value[0];
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
ssSTPI_HEADER2.Read( r, ref index);
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
public void ReadIM(RC_572f32750027334be4afde2b8efad62f r) {
this = r;
}


public static bool operator == (RC_572f32750027334be4afde2b8efad62f a, RC_572f32750027334be4afde2b8efad62f b) {
if (a.ssSTPI_HEADER2 != b.ssSTPI_HEADER2) return false;
return true;
}

public static bool operator != (RC_572f32750027334be4afde2b8efad62f a, RC_572f32750027334be4afde2b8efad62f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_572f32750027334be4afde2b8efad62f)) return false;
return (this == (RC_572f32750027334be4afde2b8efad62f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_HEADER2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_HEADER2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_HEADER2.InternalRecursiveSave();
}


public RC_572f32750027334be4afde2b8efad62f Duplicate() {
RC_572f32750027334be4afde2b8efad62f t;
t.ssSTPI_HEADER2 = (ST_af46d22a4ab690d6a003acf927bb2771Structure)this.ssSTPI_HEADER2.Duplicate();
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
if (head == "pi_header2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_HEADER2")) variable.Value = ssSTPI_HEADER2; else variable.Optimized = true;
variable.SetFieldName("pi_header2");
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
if (key == IdPI_HEADER2) {
return ssSTPI_HEADER2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_HEADER2.Key.AsGuid) {
return ssSTPI_HEADER2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_HEADER2.FillFromOther((IRecord) other.AttributeGet(IdPI_HEADER2));
}
} // RC_572f32750027334be4afde2b8efad62f
/// <summary>
/// RecordList type <code>PI_HEADER2RecordList</code> that represents a record list of
///  <code>PI_HEADER2</code>
/// </summary>
public partial class RL_a10f14286051e7f42bb15005e901f935 : GenericRecordList<RC_572f32750027334be4afde2b8efad62f>, IEnumerable, IEnumerator {

protected override RC_572f32750027334be4afde2b8efad62f GetElementDefaultValue() {
return new RC_572f32750027334be4afde2b8efad62f();
}

public T[] ToArray<T>(Func<RC_572f32750027334be4afde2b8efad62f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a10f14286051e7f42bb15005e901f935 recordList, Func<RC_572f32750027334be4afde2b8efad62f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a10f14286051e7f42bb15005e901f935(RC_572f32750027334be4afde2b8efad62f[] array) {
  RL_a10f14286051e7f42bb15005e901f935 result = new RL_a10f14286051e7f42bb15005e901f935();
result.InnerFromArray(array);
    return result;
}

public static RL_a10f14286051e7f42bb15005e901f935 ToList<T>(T[] array, Func <T, RC_572f32750027334be4afde2b8efad62f> converter) {
  RL_a10f14286051e7f42bb15005e901f935 result = new RL_a10f14286051e7f42bb15005e901f935();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a10f14286051e7f42bb15005e901f935 FromRestList<T>(RestList<T> restList, Func <T, RC_572f32750027334be4afde2b8efad62f> converter) {
  RL_a10f14286051e7f42bb15005e901f935 result = new RL_a10f14286051e7f42bb15005e901f935();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a10f14286051e7f42bb15005e901f935() : base() {
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
protected override OSList<RC_572f32750027334be4afde2b8efad62f> NewList() {
return new RL_a10f14286051e7f42bb15005e901f935();
}


} // RL_a10f14286051e7f42bb15005e901f935
}

