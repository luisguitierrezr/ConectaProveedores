namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (kTCor8dcg0aKzc_gyX1osA)
///  <code>RC_80ed1f1aac7037960518642f9bfa450d</code> that represents <code>PI_HEADERRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_HEADERRecord
public partial struct RC_80ed1f1aac7037960518642f9bfa450d : ITypedRecord<RC_80ed1f1aac7037960518642f9bfa450d> {
internal static readonly GlobalObjectKey IdPI_HEADER = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Gh_tgHCsljcFGGQvm_pFDQ");

public ST_f4885e4f480f4a52f6c05031eda6ef37Structure ssSTPI_HEADER;


public static implicit operator ST_f4885e4f480f4a52f6c05031eda6ef37Structure( RC_80ed1f1aac7037960518642f9bfa450d r) {
return r.ssSTPI_HEADER;
}

public static implicit operator RC_80ed1f1aac7037960518642f9bfa450d (ST_f4885e4f480f4a52f6c05031eda6ef37Structure r) {
RC_80ed1f1aac7037960518642f9bfa450d res = new RC_80ed1f1aac7037960518642f9bfa450d ();
res.ssSTPI_HEADER = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_80ed1f1aac7037960518642f9bfa450d() {
OptimizedAttributes = null;
ssSTPI_HEADER = new ST_f4885e4f480f4a52f6c05031eda6ef37Structure();
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
    ssSTPI_HEADER.OptimizedAttributes = value[0];
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
ssSTPI_HEADER.Read( r, ref index);
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
public void ReadIM(RC_80ed1f1aac7037960518642f9bfa450d r) {
this = r;
}


public static bool operator == (RC_80ed1f1aac7037960518642f9bfa450d a, RC_80ed1f1aac7037960518642f9bfa450d b) {
if (a.ssSTPI_HEADER != b.ssSTPI_HEADER) return false;
return true;
}

public static bool operator != (RC_80ed1f1aac7037960518642f9bfa450d a, RC_80ed1f1aac7037960518642f9bfa450d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_80ed1f1aac7037960518642f9bfa450d)) return false;
return (this == (RC_80ed1f1aac7037960518642f9bfa450d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_HEADER.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_HEADER.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_HEADER.InternalRecursiveSave();
}


public RC_80ed1f1aac7037960518642f9bfa450d Duplicate() {
RC_80ed1f1aac7037960518642f9bfa450d t;
t.ssSTPI_HEADER = (ST_f4885e4f480f4a52f6c05031eda6ef37Structure)this.ssSTPI_HEADER.Duplicate();
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
if (head == "pi_header") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_HEADER")) variable.Value = ssSTPI_HEADER; else variable.Optimized = true;
variable.SetFieldName("pi_header");
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
if (key == IdPI_HEADER) {
return ssSTPI_HEADER;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_HEADER.Key.AsGuid) {
return ssSTPI_HEADER;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_HEADER.FillFromOther((IRecord) other.AttributeGet(IdPI_HEADER));
}
} // RC_80ed1f1aac7037960518642f9bfa450d
/// <summary>
/// RecordList type <code>PI_HEADERRecordList</code> that represents a record list of
///  <code>PI_HEADER</code>
/// </summary>
public partial class RL_a96b597f1cb2334a343278fcf9834926 : GenericRecordList<RC_80ed1f1aac7037960518642f9bfa450d>, IEnumerable, IEnumerator {

protected override RC_80ed1f1aac7037960518642f9bfa450d GetElementDefaultValue() {
return new RC_80ed1f1aac7037960518642f9bfa450d();
}

public T[] ToArray<T>(Func<RC_80ed1f1aac7037960518642f9bfa450d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a96b597f1cb2334a343278fcf9834926 recordList, Func<RC_80ed1f1aac7037960518642f9bfa450d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a96b597f1cb2334a343278fcf9834926(RC_80ed1f1aac7037960518642f9bfa450d[] array) {
  RL_a96b597f1cb2334a343278fcf9834926 result = new RL_a96b597f1cb2334a343278fcf9834926();
result.InnerFromArray(array);
    return result;
}

public static RL_a96b597f1cb2334a343278fcf9834926 ToList<T>(T[] array, Func <T, RC_80ed1f1aac7037960518642f9bfa450d> converter) {
  RL_a96b597f1cb2334a343278fcf9834926 result = new RL_a96b597f1cb2334a343278fcf9834926();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a96b597f1cb2334a343278fcf9834926 FromRestList<T>(RestList<T> restList, Func <T, RC_80ed1f1aac7037960518642f9bfa450d> converter) {
  RL_a96b597f1cb2334a343278fcf9834926 result = new RL_a96b597f1cb2334a343278fcf9834926();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a96b597f1cb2334a343278fcf9834926() : base() {
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
protected override OSList<RC_80ed1f1aac7037960518642f9bfa450d> NewList() {
return new RL_a96b597f1cb2334a343278fcf9834926();
}


} // RL_a96b597f1cb2334a343278fcf9834926
}

