namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (3Qw0WbeLrEuiVK8DZ6VZXA)
///  <code>RC_867a4629d09a2662a976db33711cd1ff</code> that represent
/// s <code>EM_SM_MO_COSMOZ_Response_StructRecord</code> <p>Description: </p>
/// </summary>
// Name: EM_SM_MO_COSMOZ_Response_StructRecord
public partial struct RC_867a4629d09a2662a976db33711cd1ff : ITypedRecord<RC_867a4629d09a2662a976db33711cd1ff> {
internal static readonly GlobalObjectKey IdEM_SM_MO_COSMOZ_Response_Struct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*KUZ6hprQYiapdtszcRzR_w");

public ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure ssSTEM_SM_MO_COSMOZ_Response_Struct;


public static implicit operator ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure( RC_867a4629d09a2662a976db33711cd1ff r) {
return r.ssSTEM_SM_MO_COSMOZ_Response_Struct;
}

public static implicit operator RC_867a4629d09a2662a976db33711cd1ff (ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure r) {
RC_867a4629d09a2662a976db33711cd1ff res = new RC_867a4629d09a2662a976db33711cd1ff ();
res.ssSTEM_SM_MO_COSMOZ_Response_Struct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_867a4629d09a2662a976db33711cd1ff() {
OptimizedAttributes = null;
ssSTEM_SM_MO_COSMOZ_Response_Struct = new ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure();
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
    ssSTEM_SM_MO_COSMOZ_Response_Struct.OptimizedAttributes = value[0];
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
ssSTEM_SM_MO_COSMOZ_Response_Struct.Read( r, ref index);
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
public void ReadIM(RC_867a4629d09a2662a976db33711cd1ff r) {
this = r;
}


public static bool operator == (RC_867a4629d09a2662a976db33711cd1ff a, RC_867a4629d09a2662a976db33711cd1ff b) {
if (a.ssSTEM_SM_MO_COSMOZ_Response_Struct != b.ssSTEM_SM_MO_COSMOZ_Response_Struct) return false;
return true;
}

public static bool operator != (RC_867a4629d09a2662a976db33711cd1ff a, RC_867a4629d09a2662a976db33711cd1ff b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_867a4629d09a2662a976db33711cd1ff)) return false;
return (this == (RC_867a4629d09a2662a976db33711cd1ff)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEM_SM_MO_COSMOZ_Response_Struct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEM_SM_MO_COSMOZ_Response_Struct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEM_SM_MO_COSMOZ_Response_Struct.InternalRecursiveSave();
}


public RC_867a4629d09a2662a976db33711cd1ff Duplicate() {
RC_867a4629d09a2662a976db33711cd1ff t;
t.ssSTEM_SM_MO_COSMOZ_Response_Struct = (ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure)this.ssSTEM_SM_MO_COSMOZ_Response_Struct.Duplicate();
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
if (head == "em_sm_mo_cosmoz_response_struct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_SM_MO_COSMOZ_Response_Struct")) variable.Value = ssSTEM_SM_MO_COSMOZ_Response_Struct; else variable.Optimized = true;
variable.SetFieldName("em_sm_mo_cosmoz_response_struct");
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
if (key == IdEM_SM_MO_COSMOZ_Response_Struct) {
return ssSTEM_SM_MO_COSMOZ_Response_Struct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_SM_MO_COSMOZ_Response_Struct.Key.AsGuid) {
return ssSTEM_SM_MO_COSMOZ_Response_Struct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEM_SM_MO_COSMOZ_Response_Struct.FillFromOther((IRecord) other.AttributeGet(IdEM_SM_MO_COSMOZ_Response_Struct));
}
} // RC_867a4629d09a2662a976db33711cd1ff
/// <summary>
/// RecordList type <code>EM_SM_MO_COSMOZ_Response_StructRecordList</code> that represents a record
///  list of <code>EM_SM_MO_COSMOZ_Response_Struct</code>
/// </summary>
public partial class RL_d8fd0634b1d150e35f8c3ed567fe540e : GenericRecordList<RC_867a4629d09a2662a976db33711cd1ff>, IEnumerable, IEnumerator {

protected override RC_867a4629d09a2662a976db33711cd1ff GetElementDefaultValue() {
return new RC_867a4629d09a2662a976db33711cd1ff();
}

public T[] ToArray<T>(Func<RC_867a4629d09a2662a976db33711cd1ff, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d8fd0634b1d150e35f8c3ed567fe540e recordList, Func<RC_867a4629d09a2662a976db33711cd1ff, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d8fd0634b1d150e35f8c3ed567fe540e(RC_867a4629d09a2662a976db33711cd1ff[] array) {
  RL_d8fd0634b1d150e35f8c3ed567fe540e result = new RL_d8fd0634b1d150e35f8c3ed567fe540e();
result.InnerFromArray(array);
    return result;
}

public static RL_d8fd0634b1d150e35f8c3ed567fe540e ToList<T>(T[] array, Func <T, RC_867a4629d09a2662a976db33711cd1ff> converter) {
  RL_d8fd0634b1d150e35f8c3ed567fe540e result = new RL_d8fd0634b1d150e35f8c3ed567fe540e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d8fd0634b1d150e35f8c3ed567fe540e FromRestList<T>(RestList<T> restList, Func <T, RC_867a4629d09a2662a976db33711cd1ff> converter) {
  RL_d8fd0634b1d150e35f8c3ed567fe540e result = new RL_d8fd0634b1d150e35f8c3ed567fe540e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d8fd0634b1d150e35f8c3ed567fe540e() : base() {
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
protected override OSList<RC_867a4629d09a2662a976db33711cd1ff> NewList() {
return new RL_d8fd0634b1d150e35f8c3ed567fe540e();
}


} // RL_d8fd0634b1d150e35f8c3ed567fe540e
}

