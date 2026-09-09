namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (slksZGjRKUGYf_ydYe6ayw)
///  <code>RC_5b3a110e736062950b0c6cfa935e61d0</code> that represents <code>PI_ITEMRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_ITEMRecord
public partial struct RC_5b3a110e736062950b0c6cfa935e61d0 : ITypedRecord<RC_5b3a110e736062950b0c6cfa935e61d0> {
internal static readonly GlobalObjectKey IdPI_ITEM = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*DhE6W2BzlWILDGz6k15h0A");

public ST_d34c4878f870709fdbf7a3e48e70a4edStructure ssSTPI_ITEM;


public static implicit operator ST_d34c4878f870709fdbf7a3e48e70a4edStructure( RC_5b3a110e736062950b0c6cfa935e61d0 r) {
return r.ssSTPI_ITEM;
}

public static implicit operator RC_5b3a110e736062950b0c6cfa935e61d0 (ST_d34c4878f870709fdbf7a3e48e70a4edStructure r) {
RC_5b3a110e736062950b0c6cfa935e61d0 res = new RC_5b3a110e736062950b0c6cfa935e61d0 ();
res.ssSTPI_ITEM = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_5b3a110e736062950b0c6cfa935e61d0() {
OptimizedAttributes = null;
ssSTPI_ITEM = new ST_d34c4878f870709fdbf7a3e48e70a4edStructure();
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
    ssSTPI_ITEM.OptimizedAttributes = value[0];
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
ssSTPI_ITEM.Read( r, ref index);
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
public void ReadIM(RC_5b3a110e736062950b0c6cfa935e61d0 r) {
this = r;
}


public static bool operator == (RC_5b3a110e736062950b0c6cfa935e61d0 a, RC_5b3a110e736062950b0c6cfa935e61d0 b) {
if (a.ssSTPI_ITEM != b.ssSTPI_ITEM) return false;
return true;
}

public static bool operator != (RC_5b3a110e736062950b0c6cfa935e61d0 a, RC_5b3a110e736062950b0c6cfa935e61d0 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5b3a110e736062950b0c6cfa935e61d0)) return false;
return (this == (RC_5b3a110e736062950b0c6cfa935e61d0)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_ITEM.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_ITEM.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_ITEM.InternalRecursiveSave();
}


public RC_5b3a110e736062950b0c6cfa935e61d0 Duplicate() {
RC_5b3a110e736062950b0c6cfa935e61d0 t;
t.ssSTPI_ITEM = (ST_d34c4878f870709fdbf7a3e48e70a4edStructure)this.ssSTPI_ITEM.Duplicate();
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
if (head == "pi_item") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM")) variable.Value = ssSTPI_ITEM; else variable.Optimized = true;
variable.SetFieldName("pi_item");
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
if (key == IdPI_ITEM) {
return ssSTPI_ITEM;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_ITEM.Key.AsGuid) {
return ssSTPI_ITEM;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_ITEM.FillFromOther((IRecord) other.AttributeGet(IdPI_ITEM));
}
} // RC_5b3a110e736062950b0c6cfa935e61d0
/// <summary>
/// RecordList type <code>PI_ITEMRecordList</code> that represents a record list of
///  <code>PI_ITEM</code>
/// </summary>
public partial class RL_e9f34606a5a1d0ddefd1ad8c1160a722 : GenericRecordList<RC_5b3a110e736062950b0c6cfa935e61d0>, IEnumerable, IEnumerator {

protected override RC_5b3a110e736062950b0c6cfa935e61d0 GetElementDefaultValue() {
return new RC_5b3a110e736062950b0c6cfa935e61d0();
}

public T[] ToArray<T>(Func<RC_5b3a110e736062950b0c6cfa935e61d0, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e9f34606a5a1d0ddefd1ad8c1160a722 recordList, Func<RC_5b3a110e736062950b0c6cfa935e61d0, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e9f34606a5a1d0ddefd1ad8c1160a722(RC_5b3a110e736062950b0c6cfa935e61d0[] array) {
  RL_e9f34606a5a1d0ddefd1ad8c1160a722 result = new RL_e9f34606a5a1d0ddefd1ad8c1160a722();
result.InnerFromArray(array);
    return result;
}

public static RL_e9f34606a5a1d0ddefd1ad8c1160a722 ToList<T>(T[] array, Func <T, RC_5b3a110e736062950b0c6cfa935e61d0> converter) {
  RL_e9f34606a5a1d0ddefd1ad8c1160a722 result = new RL_e9f34606a5a1d0ddefd1ad8c1160a722();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e9f34606a5a1d0ddefd1ad8c1160a722 FromRestList<T>(RestList<T> restList, Func <T, RC_5b3a110e736062950b0c6cfa935e61d0> converter) {
  RL_e9f34606a5a1d0ddefd1ad8c1160a722 result = new RL_e9f34606a5a1d0ddefd1ad8c1160a722();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e9f34606a5a1d0ddefd1ad8c1160a722() : base() {
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
protected override OSList<RC_5b3a110e736062950b0c6cfa935e61d0> NewList() {
return new RL_e9f34606a5a1d0ddefd1ad8c1160a722();
}


} // RL_e9f34606a5a1d0ddefd1ad8c1160a722
}

