namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Dv65xG0lgUi1zTb_b3AEQg)
///  <code>RC_473d44d37727fbe7aa021ec19b49122c</code> that represents <code>PI_ITEM_EM_MORecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_ITEM_EM_MORecord
public partial struct RC_473d44d37727fbe7aa021ec19b49122c : ITypedRecord<RC_473d44d37727fbe7aa021ec19b49122c> {
internal static readonly GlobalObjectKey IdPI_ITEM_EM_MO = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*00Q9Ryd35_uqAh7Bm0kSLA");

public ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure ssSTPI_ITEM_EM_MO;


public static implicit operator ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure( RC_473d44d37727fbe7aa021ec19b49122c r) {
return r.ssSTPI_ITEM_EM_MO;
}

public static implicit operator RC_473d44d37727fbe7aa021ec19b49122c (ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure r) {
RC_473d44d37727fbe7aa021ec19b49122c res = new RC_473d44d37727fbe7aa021ec19b49122c ();
res.ssSTPI_ITEM_EM_MO = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_473d44d37727fbe7aa021ec19b49122c() {
OptimizedAttributes = null;
ssSTPI_ITEM_EM_MO = new ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure();
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
    ssSTPI_ITEM_EM_MO.OptimizedAttributes = value[0];
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
ssSTPI_ITEM_EM_MO.Read( r, ref index);
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
public void ReadIM(RC_473d44d37727fbe7aa021ec19b49122c r) {
this = r;
}


public static bool operator == (RC_473d44d37727fbe7aa021ec19b49122c a, RC_473d44d37727fbe7aa021ec19b49122c b) {
if (a.ssSTPI_ITEM_EM_MO != b.ssSTPI_ITEM_EM_MO) return false;
return true;
}

public static bool operator != (RC_473d44d37727fbe7aa021ec19b49122c a, RC_473d44d37727fbe7aa021ec19b49122c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_473d44d37727fbe7aa021ec19b49122c)) return false;
return (this == (RC_473d44d37727fbe7aa021ec19b49122c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_ITEM_EM_MO.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_ITEM_EM_MO.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_ITEM_EM_MO.InternalRecursiveSave();
}


public RC_473d44d37727fbe7aa021ec19b49122c Duplicate() {
RC_473d44d37727fbe7aa021ec19b49122c t;
t.ssSTPI_ITEM_EM_MO = (ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure)this.ssSTPI_ITEM_EM_MO.Duplicate();
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
if (head == "pi_item_em_mo") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM_EM_MO")) variable.Value = ssSTPI_ITEM_EM_MO; else variable.Optimized = true;
variable.SetFieldName("pi_item_em_mo");
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
if (key == IdPI_ITEM_EM_MO) {
return ssSTPI_ITEM_EM_MO;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_ITEM_EM_MO.Key.AsGuid) {
return ssSTPI_ITEM_EM_MO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_ITEM_EM_MO.FillFromOther((IRecord) other.AttributeGet(IdPI_ITEM_EM_MO));
}
} // RC_473d44d37727fbe7aa021ec19b49122c
/// <summary>
/// RecordList type <code>PI_ITEM_EM_MORecordList</code> that represents a record list of
///  <code>PI_ITEM_EM_MO</code>
/// </summary>
public partial class RL_090da7168a7f01f9e0e1105ce1682494 : GenericRecordList<RC_473d44d37727fbe7aa021ec19b49122c>, IEnumerable, IEnumerator {

protected override RC_473d44d37727fbe7aa021ec19b49122c GetElementDefaultValue() {
return new RC_473d44d37727fbe7aa021ec19b49122c();
}

public T[] ToArray<T>(Func<RC_473d44d37727fbe7aa021ec19b49122c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_090da7168a7f01f9e0e1105ce1682494 recordList, Func<RC_473d44d37727fbe7aa021ec19b49122c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_090da7168a7f01f9e0e1105ce1682494(RC_473d44d37727fbe7aa021ec19b49122c[] array) {
  RL_090da7168a7f01f9e0e1105ce1682494 result = new RL_090da7168a7f01f9e0e1105ce1682494();
result.InnerFromArray(array);
    return result;
}

public static RL_090da7168a7f01f9e0e1105ce1682494 ToList<T>(T[] array, Func <T, RC_473d44d37727fbe7aa021ec19b49122c> converter) {
  RL_090da7168a7f01f9e0e1105ce1682494 result = new RL_090da7168a7f01f9e0e1105ce1682494();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_090da7168a7f01f9e0e1105ce1682494 FromRestList<T>(RestList<T> restList, Func <T, RC_473d44d37727fbe7aa021ec19b49122c> converter) {
  RL_090da7168a7f01f9e0e1105ce1682494 result = new RL_090da7168a7f01f9e0e1105ce1682494();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_090da7168a7f01f9e0e1105ce1682494() : base() {
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
protected override OSList<RC_473d44d37727fbe7aa021ec19b49122c> NewList() {
return new RL_090da7168a7f01f9e0e1105ce1682494();
}


} // RL_090da7168a7f01f9e0e1105ce1682494
}

