namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (w_miFT_LMkCDkR0iNNPM6Q)
///  <code>RC_b8a0645b6211d97a3945398c9bceb91c</code> that represents <code>PI_ITEM_SM2Record</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_ITEM_SM2Record
public partial struct RC_b8a0645b6211d97a3945398c9bceb91c : ITypedRecord<RC_b8a0645b6211d97a3945398c9bceb91c> {
internal static readonly GlobalObjectKey IdPI_ITEM_SM2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*W2SguBFietk5RTmMm865HA");

public ST_9327164801e6ab5e342b0e8e98c59312Structure ssSTPI_ITEM_SM2;


public static implicit operator ST_9327164801e6ab5e342b0e8e98c59312Structure( RC_b8a0645b6211d97a3945398c9bceb91c r) {
return r.ssSTPI_ITEM_SM2;
}

public static implicit operator RC_b8a0645b6211d97a3945398c9bceb91c (ST_9327164801e6ab5e342b0e8e98c59312Structure r) {
RC_b8a0645b6211d97a3945398c9bceb91c res = new RC_b8a0645b6211d97a3945398c9bceb91c ();
res.ssSTPI_ITEM_SM2 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_b8a0645b6211d97a3945398c9bceb91c() {
OptimizedAttributes = null;
ssSTPI_ITEM_SM2 = new ST_9327164801e6ab5e342b0e8e98c59312Structure();
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
    ssSTPI_ITEM_SM2.OptimizedAttributes = value[0];
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
ssSTPI_ITEM_SM2.Read( r, ref index);
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
public void ReadIM(RC_b8a0645b6211d97a3945398c9bceb91c r) {
this = r;
}


public static bool operator == (RC_b8a0645b6211d97a3945398c9bceb91c a, RC_b8a0645b6211d97a3945398c9bceb91c b) {
if (a.ssSTPI_ITEM_SM2 != b.ssSTPI_ITEM_SM2) return false;
return true;
}

public static bool operator != (RC_b8a0645b6211d97a3945398c9bceb91c a, RC_b8a0645b6211d97a3945398c9bceb91c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b8a0645b6211d97a3945398c9bceb91c)) return false;
return (this == (RC_b8a0645b6211d97a3945398c9bceb91c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_ITEM_SM2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_ITEM_SM2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_ITEM_SM2.InternalRecursiveSave();
}


public RC_b8a0645b6211d97a3945398c9bceb91c Duplicate() {
RC_b8a0645b6211d97a3945398c9bceb91c t;
t.ssSTPI_ITEM_SM2 = (ST_9327164801e6ab5e342b0e8e98c59312Structure)this.ssSTPI_ITEM_SM2.Duplicate();
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
if (head == "pi_item_sm2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM_SM2")) variable.Value = ssSTPI_ITEM_SM2; else variable.Optimized = true;
variable.SetFieldName("pi_item_sm2");
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
if (key == IdPI_ITEM_SM2) {
return ssSTPI_ITEM_SM2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_ITEM_SM2.Key.AsGuid) {
return ssSTPI_ITEM_SM2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_ITEM_SM2.FillFromOther((IRecord) other.AttributeGet(IdPI_ITEM_SM2));
}
} // RC_b8a0645b6211d97a3945398c9bceb91c
/// <summary>
/// RecordList type <code>PI_ITEM_SM2RecordList</code> that represents a record list of
///  <code>PI_ITEM_SM2</code>
/// </summary>
public partial class RL_c1311940b83fafdeefa2ce613c3ddb7a : GenericRecordList<RC_b8a0645b6211d97a3945398c9bceb91c>, IEnumerable, IEnumerator {

protected override RC_b8a0645b6211d97a3945398c9bceb91c GetElementDefaultValue() {
return new RC_b8a0645b6211d97a3945398c9bceb91c();
}

public T[] ToArray<T>(Func<RC_b8a0645b6211d97a3945398c9bceb91c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c1311940b83fafdeefa2ce613c3ddb7a recordList, Func<RC_b8a0645b6211d97a3945398c9bceb91c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c1311940b83fafdeefa2ce613c3ddb7a(RC_b8a0645b6211d97a3945398c9bceb91c[] array) {
  RL_c1311940b83fafdeefa2ce613c3ddb7a result = new RL_c1311940b83fafdeefa2ce613c3ddb7a();
result.InnerFromArray(array);
    return result;
}

public static RL_c1311940b83fafdeefa2ce613c3ddb7a ToList<T>(T[] array, Func <T, RC_b8a0645b6211d97a3945398c9bceb91c> converter) {
  RL_c1311940b83fafdeefa2ce613c3ddb7a result = new RL_c1311940b83fafdeefa2ce613c3ddb7a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c1311940b83fafdeefa2ce613c3ddb7a FromRestList<T>(RestList<T> restList, Func <T, RC_b8a0645b6211d97a3945398c9bceb91c> converter) {
  RL_c1311940b83fafdeefa2ce613c3ddb7a result = new RL_c1311940b83fafdeefa2ce613c3ddb7a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c1311940b83fafdeefa2ce613c3ddb7a() : base() {
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
protected override OSList<RC_b8a0645b6211d97a3945398c9bceb91c> NewList() {
return new RL_c1311940b83fafdeefa2ce613c3ddb7a();
}


} // RL_c1311940b83fafdeefa2ce613c3ddb7a
}

