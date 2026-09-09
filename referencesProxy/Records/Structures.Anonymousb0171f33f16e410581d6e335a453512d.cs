namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (Mx8XsG7xBUGB1uM1pFNRLQ)
///  <code>RC_92d917d40b5023c13ba97b8cae6eddac</code> that represents <code>PI_ITEM_SM_MORecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_ITEM_SM_MORecord
public partial struct RC_92d917d40b5023c13ba97b8cae6eddac : ITypedRecord<RC_92d917d40b5023c13ba97b8cae6eddac> {
internal static readonly GlobalObjectKey IdPI_ITEM_SM_MO = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1BfZklALwSM7qXuMrm7drA");

public ST_64e1f00088c363cc4d22cb46cb1c9dacStructure ssSTPI_ITEM_SM_MO;


public static implicit operator ST_64e1f00088c363cc4d22cb46cb1c9dacStructure( RC_92d917d40b5023c13ba97b8cae6eddac r) {
return r.ssSTPI_ITEM_SM_MO;
}

public static implicit operator RC_92d917d40b5023c13ba97b8cae6eddac (ST_64e1f00088c363cc4d22cb46cb1c9dacStructure r) {
RC_92d917d40b5023c13ba97b8cae6eddac res = new RC_92d917d40b5023c13ba97b8cae6eddac ();
res.ssSTPI_ITEM_SM_MO = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_92d917d40b5023c13ba97b8cae6eddac() {
OptimizedAttributes = null;
ssSTPI_ITEM_SM_MO = new ST_64e1f00088c363cc4d22cb46cb1c9dacStructure();
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
    ssSTPI_ITEM_SM_MO.OptimizedAttributes = value[0];
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
ssSTPI_ITEM_SM_MO.Read( r, ref index);
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
public void ReadIM(RC_92d917d40b5023c13ba97b8cae6eddac r) {
this = r;
}


public static bool operator == (RC_92d917d40b5023c13ba97b8cae6eddac a, RC_92d917d40b5023c13ba97b8cae6eddac b) {
if (a.ssSTPI_ITEM_SM_MO != b.ssSTPI_ITEM_SM_MO) return false;
return true;
}

public static bool operator != (RC_92d917d40b5023c13ba97b8cae6eddac a, RC_92d917d40b5023c13ba97b8cae6eddac b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_92d917d40b5023c13ba97b8cae6eddac)) return false;
return (this == (RC_92d917d40b5023c13ba97b8cae6eddac)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_ITEM_SM_MO.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_ITEM_SM_MO.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_ITEM_SM_MO.InternalRecursiveSave();
}


public RC_92d917d40b5023c13ba97b8cae6eddac Duplicate() {
RC_92d917d40b5023c13ba97b8cae6eddac t;
t.ssSTPI_ITEM_SM_MO = (ST_64e1f00088c363cc4d22cb46cb1c9dacStructure)this.ssSTPI_ITEM_SM_MO.Duplicate();
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
if (head == "pi_item_sm_mo") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM_SM_MO")) variable.Value = ssSTPI_ITEM_SM_MO; else variable.Optimized = true;
variable.SetFieldName("pi_item_sm_mo");
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
if (key == IdPI_ITEM_SM_MO) {
return ssSTPI_ITEM_SM_MO;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_ITEM_SM_MO.Key.AsGuid) {
return ssSTPI_ITEM_SM_MO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_ITEM_SM_MO.FillFromOther((IRecord) other.AttributeGet(IdPI_ITEM_SM_MO));
}
} // RC_92d917d40b5023c13ba97b8cae6eddac
/// <summary>
/// RecordList type <code>PI_ITEM_SM_MORecordList</code> that represents a record list of
///  <code>PI_ITEM_SM_MO</code>
/// </summary>
public partial class RL_3dce10a2be5ea301073aa4e050993fb8 : GenericRecordList<RC_92d917d40b5023c13ba97b8cae6eddac>, IEnumerable, IEnumerator {

protected override RC_92d917d40b5023c13ba97b8cae6eddac GetElementDefaultValue() {
return new RC_92d917d40b5023c13ba97b8cae6eddac();
}

public T[] ToArray<T>(Func<RC_92d917d40b5023c13ba97b8cae6eddac, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3dce10a2be5ea301073aa4e050993fb8 recordList, Func<RC_92d917d40b5023c13ba97b8cae6eddac, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3dce10a2be5ea301073aa4e050993fb8(RC_92d917d40b5023c13ba97b8cae6eddac[] array) {
  RL_3dce10a2be5ea301073aa4e050993fb8 result = new RL_3dce10a2be5ea301073aa4e050993fb8();
result.InnerFromArray(array);
    return result;
}

public static RL_3dce10a2be5ea301073aa4e050993fb8 ToList<T>(T[] array, Func <T, RC_92d917d40b5023c13ba97b8cae6eddac> converter) {
  RL_3dce10a2be5ea301073aa4e050993fb8 result = new RL_3dce10a2be5ea301073aa4e050993fb8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3dce10a2be5ea301073aa4e050993fb8 FromRestList<T>(RestList<T> restList, Func <T, RC_92d917d40b5023c13ba97b8cae6eddac> converter) {
  RL_3dce10a2be5ea301073aa4e050993fb8 result = new RL_3dce10a2be5ea301073aa4e050993fb8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3dce10a2be5ea301073aa4e050993fb8() : base() {
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
protected override OSList<RC_92d917d40b5023c13ba97b8cae6eddac> NewList() {
return new RL_3dce10a2be5ea301073aa4e050993fb8();
}


} // RL_3dce10a2be5ea301073aa4e050993fb8
}

