namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (CahMJ6L1qEqQgoNxDhqjTA)
///  <code>RC_5785ca28d1d4c2bc76a000f13481f797</code> that represents <code>PI_ITEM_SM_CECORecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_ITEM_SM_CECORecord
public partial struct RC_5785ca28d1d4c2bc76a000f13481f797 : ITypedRecord<RC_5785ca28d1d4c2bc76a000f13481f797> {
internal static readonly GlobalObjectKey IdPI_ITEM_SM_CECO = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*KMqFV9TRvMJ2oADxNIH3lw");

public ST_1241dbde99de907a27732884f6e65ab4Structure ssSTPI_ITEM_SM_CECO;


public static implicit operator ST_1241dbde99de907a27732884f6e65ab4Structure( RC_5785ca28d1d4c2bc76a000f13481f797 r) {
return r.ssSTPI_ITEM_SM_CECO;
}

public static implicit operator RC_5785ca28d1d4c2bc76a000f13481f797 (ST_1241dbde99de907a27732884f6e65ab4Structure r) {
RC_5785ca28d1d4c2bc76a000f13481f797 res = new RC_5785ca28d1d4c2bc76a000f13481f797 ();
res.ssSTPI_ITEM_SM_CECO = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_5785ca28d1d4c2bc76a000f13481f797() {
OptimizedAttributes = null;
ssSTPI_ITEM_SM_CECO = new ST_1241dbde99de907a27732884f6e65ab4Structure();
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
    ssSTPI_ITEM_SM_CECO.OptimizedAttributes = value[0];
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
ssSTPI_ITEM_SM_CECO.Read( r, ref index);
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
public void ReadIM(RC_5785ca28d1d4c2bc76a000f13481f797 r) {
this = r;
}


public static bool operator == (RC_5785ca28d1d4c2bc76a000f13481f797 a, RC_5785ca28d1d4c2bc76a000f13481f797 b) {
if (a.ssSTPI_ITEM_SM_CECO != b.ssSTPI_ITEM_SM_CECO) return false;
return true;
}

public static bool operator != (RC_5785ca28d1d4c2bc76a000f13481f797 a, RC_5785ca28d1d4c2bc76a000f13481f797 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5785ca28d1d4c2bc76a000f13481f797)) return false;
return (this == (RC_5785ca28d1d4c2bc76a000f13481f797)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_ITEM_SM_CECO.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_ITEM_SM_CECO.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_ITEM_SM_CECO.InternalRecursiveSave();
}


public RC_5785ca28d1d4c2bc76a000f13481f797 Duplicate() {
RC_5785ca28d1d4c2bc76a000f13481f797 t;
t.ssSTPI_ITEM_SM_CECO = (ST_1241dbde99de907a27732884f6e65ab4Structure)this.ssSTPI_ITEM_SM_CECO.Duplicate();
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
if (head == "pi_item_sm_ceco") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM_SM_CECO")) variable.Value = ssSTPI_ITEM_SM_CECO; else variable.Optimized = true;
variable.SetFieldName("pi_item_sm_ceco");
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
if (key == IdPI_ITEM_SM_CECO) {
return ssSTPI_ITEM_SM_CECO;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_ITEM_SM_CECO.Key.AsGuid) {
return ssSTPI_ITEM_SM_CECO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_ITEM_SM_CECO.FillFromOther((IRecord) other.AttributeGet(IdPI_ITEM_SM_CECO));
}
} // RC_5785ca28d1d4c2bc76a000f13481f797
/// <summary>
/// RecordList type <code>PI_ITEM_SM_CECORecordList</code> that represents a record list of
///  <code>PI_ITEM_SM_CECO</code>
/// </summary>
public partial class RL_f510db47ac9ede75ab54d1fcd2948929 : GenericRecordList<RC_5785ca28d1d4c2bc76a000f13481f797>, IEnumerable, IEnumerator {

protected override RC_5785ca28d1d4c2bc76a000f13481f797 GetElementDefaultValue() {
return new RC_5785ca28d1d4c2bc76a000f13481f797();
}

public T[] ToArray<T>(Func<RC_5785ca28d1d4c2bc76a000f13481f797, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f510db47ac9ede75ab54d1fcd2948929 recordList, Func<RC_5785ca28d1d4c2bc76a000f13481f797, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f510db47ac9ede75ab54d1fcd2948929(RC_5785ca28d1d4c2bc76a000f13481f797[] array) {
  RL_f510db47ac9ede75ab54d1fcd2948929 result = new RL_f510db47ac9ede75ab54d1fcd2948929();
result.InnerFromArray(array);
    return result;
}

public static RL_f510db47ac9ede75ab54d1fcd2948929 ToList<T>(T[] array, Func <T, RC_5785ca28d1d4c2bc76a000f13481f797> converter) {
  RL_f510db47ac9ede75ab54d1fcd2948929 result = new RL_f510db47ac9ede75ab54d1fcd2948929();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f510db47ac9ede75ab54d1fcd2948929 FromRestList<T>(RestList<T> restList, Func <T, RC_5785ca28d1d4c2bc76a000f13481f797> converter) {
  RL_f510db47ac9ede75ab54d1fcd2948929 result = new RL_f510db47ac9ede75ab54d1fcd2948929();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f510db47ac9ede75ab54d1fcd2948929() : base() {
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
protected override OSList<RC_5785ca28d1d4c2bc76a000f13481f797> NewList() {
return new RL_f510db47ac9ede75ab54d1fcd2948929();
}


} // RL_f510db47ac9ede75ab54d1fcd2948929
}

