namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (9Lx2n3NkH0KaNUviCuXmYw)
///  <code>RC_fc2fa2d768001e70af464f961159f027</code> that represent
/// s <code>RequisitionFileTypesStructRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionFileTypesStructRecord
public partial struct RC_fc2fa2d768001e70af464f961159f027 : ITypedRecord<RC_fc2fa2d768001e70af464f961159f027> {
internal static readonly GlobalObjectKey IdRequisitionFileTypesStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*16Iv_ABocB6vRk+WEVnwJw");

public ST_26b16bea631cbd94cf555acb5c7a4be3Structure ssSTRequisitionFileTypesStruct;


public static implicit operator ST_26b16bea631cbd94cf555acb5c7a4be3Structure( RC_fc2fa2d768001e70af464f961159f027 r) {
return r.ssSTRequisitionFileTypesStruct;
}

public static implicit operator RC_fc2fa2d768001e70af464f961159f027 (ST_26b16bea631cbd94cf555acb5c7a4be3Structure r) {
RC_fc2fa2d768001e70af464f961159f027 res = new RC_fc2fa2d768001e70af464f961159f027 ();
res.ssSTRequisitionFileTypesStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_fc2fa2d768001e70af464f961159f027() {
OptimizedAttributes = null;
ssSTRequisitionFileTypesStruct = new ST_26b16bea631cbd94cf555acb5c7a4be3Structure();
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
    ssSTRequisitionFileTypesStruct.OptimizedAttributes = value[0];
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
ssSTRequisitionFileTypesStruct.Read( r, ref index);
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
public void ReadIM(RC_fc2fa2d768001e70af464f961159f027 r) {
this = r;
}


public static bool operator == (RC_fc2fa2d768001e70af464f961159f027 a, RC_fc2fa2d768001e70af464f961159f027 b) {
if (a.ssSTRequisitionFileTypesStruct != b.ssSTRequisitionFileTypesStruct) return false;
return true;
}

public static bool operator != (RC_fc2fa2d768001e70af464f961159f027 a, RC_fc2fa2d768001e70af464f961159f027 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_fc2fa2d768001e70af464f961159f027)) return false;
return (this == (RC_fc2fa2d768001e70af464f961159f027)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTRequisitionFileTypesStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTRequisitionFileTypesStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTRequisitionFileTypesStruct.InternalRecursiveSave();
}


public RC_fc2fa2d768001e70af464f961159f027 Duplicate() {
RC_fc2fa2d768001e70af464f961159f027 t;
t.ssSTRequisitionFileTypesStruct = (ST_26b16bea631cbd94cf555acb5c7a4be3Structure)this.ssSTRequisitionFileTypesStruct.Duplicate();
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
if (head == "requisitionfiletypesstruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionFileTypesStruct")) variable.Value = ssSTRequisitionFileTypesStruct; else variable.Optimized = true;
variable.SetFieldName("requisitionfiletypesstruct");
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
if (key == IdRequisitionFileTypesStruct) {
return ssSTRequisitionFileTypesStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionFileTypesStruct.Key.AsGuid) {
return ssSTRequisitionFileTypesStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTRequisitionFileTypesStruct.FillFromOther((IRecord) other.AttributeGet(IdRequisitionFileTypesStruct));
}
} // RC_fc2fa2d768001e70af464f961159f027
/// <summary>
/// RecordList type <code>RequisitionFileTypesStructRecordList</code> that represents a record list of
///  <code>RequisitionFileTypesStruct</code>
/// </summary>
public partial class RL_95f94705cc6cb21e0c3bb3e62832a480 : GenericRecordList<RC_fc2fa2d768001e70af464f961159f027>, IEnumerable, IEnumerator {

protected override RC_fc2fa2d768001e70af464f961159f027 GetElementDefaultValue() {
return new RC_fc2fa2d768001e70af464f961159f027();
}

public T[] ToArray<T>(Func<RC_fc2fa2d768001e70af464f961159f027, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_95f94705cc6cb21e0c3bb3e62832a480 recordList, Func<RC_fc2fa2d768001e70af464f961159f027, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_95f94705cc6cb21e0c3bb3e62832a480(RC_fc2fa2d768001e70af464f961159f027[] array) {
  RL_95f94705cc6cb21e0c3bb3e62832a480 result = new RL_95f94705cc6cb21e0c3bb3e62832a480();
result.InnerFromArray(array);
    return result;
}

public static RL_95f94705cc6cb21e0c3bb3e62832a480 ToList<T>(T[] array, Func <T, RC_fc2fa2d768001e70af464f961159f027> converter) {
  RL_95f94705cc6cb21e0c3bb3e62832a480 result = new RL_95f94705cc6cb21e0c3bb3e62832a480();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_95f94705cc6cb21e0c3bb3e62832a480 FromRestList<T>(RestList<T> restList, Func <T, RC_fc2fa2d768001e70af464f961159f027> converter) {
  RL_95f94705cc6cb21e0c3bb3e62832a480 result = new RL_95f94705cc6cb21e0c3bb3e62832a480();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_95f94705cc6cb21e0c3bb3e62832a480() : base() {
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
protected override OSList<RC_fc2fa2d768001e70af464f961159f027> NewList() {
return new RL_95f94705cc6cb21e0c3bb3e62832a480();
}


} // RL_95f94705cc6cb21e0c3bb3e62832a480
}

