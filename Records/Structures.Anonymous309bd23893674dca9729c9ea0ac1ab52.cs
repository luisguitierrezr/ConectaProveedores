namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ONKbMGeTyk2XKcnqCsGrUg)
///  <code>RC_8d6c816cab3d04c045c6166095f12882</code> that represents <code>PI_ITEM_EM_CECORecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PI_ITEM_EM_CECORecord
public partial struct RC_8d6c816cab3d04c045c6166095f12882 : ITypedRecord<RC_8d6c816cab3d04c045c6166095f12882> {
internal static readonly GlobalObjectKey IdPI_ITEM_EM_CECO = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bIFsjT2rwARFxhZglfEogg");

public ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure ssSTPI_ITEM_EM_CECO;


public static implicit operator ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure( RC_8d6c816cab3d04c045c6166095f12882 r) {
return r.ssSTPI_ITEM_EM_CECO;
}

public static implicit operator RC_8d6c816cab3d04c045c6166095f12882 (ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure r) {
RC_8d6c816cab3d04c045c6166095f12882 res = new RC_8d6c816cab3d04c045c6166095f12882 ();
res.ssSTPI_ITEM_EM_CECO = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_8d6c816cab3d04c045c6166095f12882() {
OptimizedAttributes = null;
ssSTPI_ITEM_EM_CECO = new ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure();
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
    ssSTPI_ITEM_EM_CECO.OptimizedAttributes = value[0];
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
ssSTPI_ITEM_EM_CECO.Read( r, ref index);
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
public void ReadIM(RC_8d6c816cab3d04c045c6166095f12882 r) {
this = r;
}


public static bool operator == (RC_8d6c816cab3d04c045c6166095f12882 a, RC_8d6c816cab3d04c045c6166095f12882 b) {
if (a.ssSTPI_ITEM_EM_CECO != b.ssSTPI_ITEM_EM_CECO) return false;
return true;
}

public static bool operator != (RC_8d6c816cab3d04c045c6166095f12882 a, RC_8d6c816cab3d04c045c6166095f12882 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8d6c816cab3d04c045c6166095f12882)) return false;
return (this == (RC_8d6c816cab3d04c045c6166095f12882)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTPI_ITEM_EM_CECO.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTPI_ITEM_EM_CECO.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTPI_ITEM_EM_CECO.InternalRecursiveSave();
}


public RC_8d6c816cab3d04c045c6166095f12882 Duplicate() {
RC_8d6c816cab3d04c045c6166095f12882 t;
t.ssSTPI_ITEM_EM_CECO = (ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure)this.ssSTPI_ITEM_EM_CECO.Duplicate();
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
if (head == "pi_item_em_ceco") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM_EM_CECO")) variable.Value = ssSTPI_ITEM_EM_CECO; else variable.Optimized = true;
variable.SetFieldName("pi_item_em_ceco");
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
if (key == IdPI_ITEM_EM_CECO) {
return ssSTPI_ITEM_EM_CECO;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_ITEM_EM_CECO.Key.AsGuid) {
return ssSTPI_ITEM_EM_CECO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTPI_ITEM_EM_CECO.FillFromOther((IRecord) other.AttributeGet(IdPI_ITEM_EM_CECO));
}
} // RC_8d6c816cab3d04c045c6166095f12882
/// <summary>
/// RecordList type <code>PI_ITEM_EM_CECORecordList</code> that represents a record list of
///  <code>PI_ITEM_EM_CECO</code>
/// </summary>
public partial class RL_857d80c9039ab5c116dfc1d5456f34a1 : GenericRecordList<RC_8d6c816cab3d04c045c6166095f12882>, IEnumerable, IEnumerator {

protected override RC_8d6c816cab3d04c045c6166095f12882 GetElementDefaultValue() {
return new RC_8d6c816cab3d04c045c6166095f12882();
}

public T[] ToArray<T>(Func<RC_8d6c816cab3d04c045c6166095f12882, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_857d80c9039ab5c116dfc1d5456f34a1 recordList, Func<RC_8d6c816cab3d04c045c6166095f12882, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_857d80c9039ab5c116dfc1d5456f34a1(RC_8d6c816cab3d04c045c6166095f12882[] array) {
  RL_857d80c9039ab5c116dfc1d5456f34a1 result = new RL_857d80c9039ab5c116dfc1d5456f34a1();
result.InnerFromArray(array);
    return result;
}

public static RL_857d80c9039ab5c116dfc1d5456f34a1 ToList<T>(T[] array, Func <T, RC_8d6c816cab3d04c045c6166095f12882> converter) {
  RL_857d80c9039ab5c116dfc1d5456f34a1 result = new RL_857d80c9039ab5c116dfc1d5456f34a1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_857d80c9039ab5c116dfc1d5456f34a1 FromRestList<T>(RestList<T> restList, Func <T, RC_8d6c816cab3d04c045c6166095f12882> converter) {
  RL_857d80c9039ab5c116dfc1d5456f34a1 result = new RL_857d80c9039ab5c116dfc1d5456f34a1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_857d80c9039ab5c116dfc1d5456f34a1() : base() {
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
protected override OSList<RC_8d6c816cab3d04c045c6166095f12882> NewList() {
return new RL_857d80c9039ab5c116dfc1d5456f34a1();
}


} // RL_857d80c9039ab5c116dfc1d5456f34a1
}

