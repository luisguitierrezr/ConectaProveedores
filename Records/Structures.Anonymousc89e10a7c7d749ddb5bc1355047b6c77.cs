namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (pxCeyNfH3Um1vBNVBHtsdw)
///  <code>RC_11e209a1965a36ac5fa26385f1f26680</code> that represent
/// s <code>EM_SM_RM_COSMOZ_RequestRecord</code> <p>Description: </p>
/// </summary>
// Name: EM_SM_RM_COSMOZ_RequestRecord
public partial struct RC_11e209a1965a36ac5fa26385f1f26680 : ITypedRecord<RC_11e209a1965a36ac5fa26385f1f26680> {
internal static readonly GlobalObjectKey IdEM_SM_RM_COSMOZ_Request = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*oQniEVqWrDZfomOF8fJmgA");

public ST_c338780fd6468541199340ed93f1aecdStructure ssSTEM_SM_RM_COSMOZ_Request;


public static implicit operator ST_c338780fd6468541199340ed93f1aecdStructure( RC_11e209a1965a36ac5fa26385f1f26680 r) {
return r.ssSTEM_SM_RM_COSMOZ_Request;
}

public static implicit operator RC_11e209a1965a36ac5fa26385f1f26680 (ST_c338780fd6468541199340ed93f1aecdStructure r) {
RC_11e209a1965a36ac5fa26385f1f26680 res = new RC_11e209a1965a36ac5fa26385f1f26680 ();
res.ssSTEM_SM_RM_COSMOZ_Request = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_11e209a1965a36ac5fa26385f1f26680() {
OptimizedAttributes = null;
ssSTEM_SM_RM_COSMOZ_Request = new ST_c338780fd6468541199340ed93f1aecdStructure();
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
    ssSTEM_SM_RM_COSMOZ_Request.OptimizedAttributes = value[0];
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
ssSTEM_SM_RM_COSMOZ_Request.Read( r, ref index);
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
public void ReadIM(RC_11e209a1965a36ac5fa26385f1f26680 r) {
this = r;
}


public static bool operator == (RC_11e209a1965a36ac5fa26385f1f26680 a, RC_11e209a1965a36ac5fa26385f1f26680 b) {
if (a.ssSTEM_SM_RM_COSMOZ_Request != b.ssSTEM_SM_RM_COSMOZ_Request) return false;
return true;
}

public static bool operator != (RC_11e209a1965a36ac5fa26385f1f26680 a, RC_11e209a1965a36ac5fa26385f1f26680 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_11e209a1965a36ac5fa26385f1f26680)) return false;
return (this == (RC_11e209a1965a36ac5fa26385f1f26680)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEM_SM_RM_COSMOZ_Request.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEM_SM_RM_COSMOZ_Request.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEM_SM_RM_COSMOZ_Request.InternalRecursiveSave();
}


public RC_11e209a1965a36ac5fa26385f1f26680 Duplicate() {
RC_11e209a1965a36ac5fa26385f1f26680 t;
t.ssSTEM_SM_RM_COSMOZ_Request = (ST_c338780fd6468541199340ed93f1aecdStructure)this.ssSTEM_SM_RM_COSMOZ_Request.Duplicate();
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
if (head == "em_sm_rm_cosmoz_request") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_SM_RM_COSMOZ_Request")) variable.Value = ssSTEM_SM_RM_COSMOZ_Request; else variable.Optimized = true;
variable.SetFieldName("em_sm_rm_cosmoz_request");
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
if (key == IdEM_SM_RM_COSMOZ_Request) {
return ssSTEM_SM_RM_COSMOZ_Request;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_SM_RM_COSMOZ_Request.Key.AsGuid) {
return ssSTEM_SM_RM_COSMOZ_Request;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEM_SM_RM_COSMOZ_Request.FillFromOther((IRecord) other.AttributeGet(IdEM_SM_RM_COSMOZ_Request));
}
} // RC_11e209a1965a36ac5fa26385f1f26680
/// <summary>
/// RecordList type <code>EM_SM_RM_COSMOZ_RequestRecordList</code> that represents a record list of
///  <code>EM_SM_RM_COSMOZ_Request</code>
/// </summary>
public partial class RL_c88b18f160b18534200d657a9b898684 : GenericRecordList<RC_11e209a1965a36ac5fa26385f1f26680>, IEnumerable, IEnumerator {

protected override RC_11e209a1965a36ac5fa26385f1f26680 GetElementDefaultValue() {
return new RC_11e209a1965a36ac5fa26385f1f26680();
}

public T[] ToArray<T>(Func<RC_11e209a1965a36ac5fa26385f1f26680, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c88b18f160b18534200d657a9b898684 recordList, Func<RC_11e209a1965a36ac5fa26385f1f26680, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c88b18f160b18534200d657a9b898684(RC_11e209a1965a36ac5fa26385f1f26680[] array) {
  RL_c88b18f160b18534200d657a9b898684 result = new RL_c88b18f160b18534200d657a9b898684();
result.InnerFromArray(array);
    return result;
}

public static RL_c88b18f160b18534200d657a9b898684 ToList<T>(T[] array, Func <T, RC_11e209a1965a36ac5fa26385f1f26680> converter) {
  RL_c88b18f160b18534200d657a9b898684 result = new RL_c88b18f160b18534200d657a9b898684();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c88b18f160b18534200d657a9b898684 FromRestList<T>(RestList<T> restList, Func <T, RC_11e209a1965a36ac5fa26385f1f26680> converter) {
  RL_c88b18f160b18534200d657a9b898684 result = new RL_c88b18f160b18534200d657a9b898684();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c88b18f160b18534200d657a9b898684() : base() {
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
protected override OSList<RC_11e209a1965a36ac5fa26385f1f26680> NewList() {
return new RL_c88b18f160b18534200d657a9b898684();
}


} // RL_c88b18f160b18534200d657a9b898684
}

