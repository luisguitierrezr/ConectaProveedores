namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Nrz+panizEWp0WvHWD3cFw)
///  <code>RC_7317bc524644d05efff768dccb02d1e1</code> that represent
/// s <code>InvoicesReport48Record</code> <p>Description: </p>
/// </summary>
// Name: InvoicesReport48Record
public partial struct RC_7317bc524644d05efff768dccb02d1e1 : ITypedRecord<RC_7317bc524644d05efff768dccb02d1e1> {
internal static readonly GlobalObjectKey IdInvoicesReport48 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*UrwXc0RGXtD_92jcywLR4Q");

public ST_c882e4a9305466afcdc9cd6a9ad70f15Structure ssSTInvoicesReport48;


public static implicit operator ST_c882e4a9305466afcdc9cd6a9ad70f15Structure( RC_7317bc524644d05efff768dccb02d1e1 r) {
return r.ssSTInvoicesReport48;
}

public static implicit operator RC_7317bc524644d05efff768dccb02d1e1 (ST_c882e4a9305466afcdc9cd6a9ad70f15Structure r) {
RC_7317bc524644d05efff768dccb02d1e1 res = new RC_7317bc524644d05efff768dccb02d1e1 ();
res.ssSTInvoicesReport48 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_7317bc524644d05efff768dccb02d1e1() {
OptimizedAttributes = null;
ssSTInvoicesReport48 = new ST_c882e4a9305466afcdc9cd6a9ad70f15Structure();
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
    ssSTInvoicesReport48.OptimizedAttributes = value[0];
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
ssSTInvoicesReport48.Read( r, ref index);
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
public void ReadIM(RC_7317bc524644d05efff768dccb02d1e1 r) {
this = r;
}


public static bool operator == (RC_7317bc524644d05efff768dccb02d1e1 a, RC_7317bc524644d05efff768dccb02d1e1 b) {
if (a.ssSTInvoicesReport48 != b.ssSTInvoicesReport48) return false;
return true;
}

public static bool operator != (RC_7317bc524644d05efff768dccb02d1e1 a, RC_7317bc524644d05efff768dccb02d1e1 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7317bc524644d05efff768dccb02d1e1)) return false;
return (this == (RC_7317bc524644d05efff768dccb02d1e1)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInvoicesReport48.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInvoicesReport48.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInvoicesReport48.InternalRecursiveSave();
}


public RC_7317bc524644d05efff768dccb02d1e1 Duplicate() {
RC_7317bc524644d05efff768dccb02d1e1 t;
t.ssSTInvoicesReport48 = (ST_c882e4a9305466afcdc9cd6a9ad70f15Structure)this.ssSTInvoicesReport48.Duplicate();
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
if (head == "invoicesreport48") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoicesReport48")) variable.Value = ssSTInvoicesReport48; else variable.Optimized = true;
variable.SetFieldName("invoicesreport48");
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
if (key == IdInvoicesReport48) {
return ssSTInvoicesReport48;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoicesReport48.Key.AsGuid) {
return ssSTInvoicesReport48;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInvoicesReport48.FillFromOther((IRecord) other.AttributeGet(IdInvoicesReport48));
}
} // RC_7317bc524644d05efff768dccb02d1e1
/// <summary>
/// RecordList type <code>InvoicesReport48RecordList</code> that represents a record list of
///  <code>InvoicesReport48</code>
/// </summary>
public partial class RL_5c049a6cc7a4bc95c584097d50b3d5f0 : GenericRecordList<RC_7317bc524644d05efff768dccb02d1e1>, IEnumerable, IEnumerator {

protected override RC_7317bc524644d05efff768dccb02d1e1 GetElementDefaultValue() {
return new RC_7317bc524644d05efff768dccb02d1e1();
}

public T[] ToArray<T>(Func<RC_7317bc524644d05efff768dccb02d1e1, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5c049a6cc7a4bc95c584097d50b3d5f0 recordList, Func<RC_7317bc524644d05efff768dccb02d1e1, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5c049a6cc7a4bc95c584097d50b3d5f0(RC_7317bc524644d05efff768dccb02d1e1[] array) {
  RL_5c049a6cc7a4bc95c584097d50b3d5f0 result = new RL_5c049a6cc7a4bc95c584097d50b3d5f0();
result.InnerFromArray(array);
    return result;
}

public static RL_5c049a6cc7a4bc95c584097d50b3d5f0 ToList<T>(T[] array, Func <T, RC_7317bc524644d05efff768dccb02d1e1> converter) {
  RL_5c049a6cc7a4bc95c584097d50b3d5f0 result = new RL_5c049a6cc7a4bc95c584097d50b3d5f0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5c049a6cc7a4bc95c584097d50b3d5f0 FromRestList<T>(RestList<T> restList, Func <T, RC_7317bc524644d05efff768dccb02d1e1> converter) {
  RL_5c049a6cc7a4bc95c584097d50b3d5f0 result = new RL_5c049a6cc7a4bc95c584097d50b3d5f0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5c049a6cc7a4bc95c584097d50b3d5f0() : base() {
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
protected override OSList<RC_7317bc524644d05efff768dccb02d1e1> NewList() {
return new RL_5c049a6cc7a4bc95c584097d50b3d5f0();
}


} // RL_5c049a6cc7a4bc95c584097d50b3d5f0
}

