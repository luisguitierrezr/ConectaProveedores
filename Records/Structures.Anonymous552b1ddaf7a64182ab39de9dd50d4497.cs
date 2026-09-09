namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (2h0rVab3gkGrOd6d1Q1Elw)
///  <code>RC_d41fc9ae6fb400f4fec40304f5250129</code> that represent
/// s <code>EM_SM_CECO_COSMOZ_Request_StructRecord</code> <p>Description: </p>
/// </summary>
// Name: EM_SM_CECO_COSMOZ_Request_StructRecord
public partial struct RC_d41fc9ae6fb400f4fec40304f5250129 : ITypedRecord<RC_d41fc9ae6fb400f4fec40304f5250129> {
internal static readonly GlobalObjectKey IdEM_SM_CECO_COSMOZ_Request_Struct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rskf1LRv9AD+xAME9SUBKQ");

public ST_883584831b34399a326748c4b1ce95c9Structure ssSTEM_SM_CECO_COSMOZ_Request_Struct;


public static implicit operator ST_883584831b34399a326748c4b1ce95c9Structure( RC_d41fc9ae6fb400f4fec40304f5250129 r) {
return r.ssSTEM_SM_CECO_COSMOZ_Request_Struct;
}

public static implicit operator RC_d41fc9ae6fb400f4fec40304f5250129 (ST_883584831b34399a326748c4b1ce95c9Structure r) {
RC_d41fc9ae6fb400f4fec40304f5250129 res = new RC_d41fc9ae6fb400f4fec40304f5250129 ();
res.ssSTEM_SM_CECO_COSMOZ_Request_Struct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_d41fc9ae6fb400f4fec40304f5250129() {
OptimizedAttributes = null;
ssSTEM_SM_CECO_COSMOZ_Request_Struct = new ST_883584831b34399a326748c4b1ce95c9Structure();
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
    ssSTEM_SM_CECO_COSMOZ_Request_Struct.OptimizedAttributes = value[0];
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
ssSTEM_SM_CECO_COSMOZ_Request_Struct.Read( r, ref index);
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
public void ReadIM(RC_d41fc9ae6fb400f4fec40304f5250129 r) {
this = r;
}


public static bool operator == (RC_d41fc9ae6fb400f4fec40304f5250129 a, RC_d41fc9ae6fb400f4fec40304f5250129 b) {
if (a.ssSTEM_SM_CECO_COSMOZ_Request_Struct != b.ssSTEM_SM_CECO_COSMOZ_Request_Struct) return false;
return true;
}

public static bool operator != (RC_d41fc9ae6fb400f4fec40304f5250129 a, RC_d41fc9ae6fb400f4fec40304f5250129 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d41fc9ae6fb400f4fec40304f5250129)) return false;
return (this == (RC_d41fc9ae6fb400f4fec40304f5250129)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEM_SM_CECO_COSMOZ_Request_Struct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEM_SM_CECO_COSMOZ_Request_Struct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEM_SM_CECO_COSMOZ_Request_Struct.InternalRecursiveSave();
}


public RC_d41fc9ae6fb400f4fec40304f5250129 Duplicate() {
RC_d41fc9ae6fb400f4fec40304f5250129 t;
t.ssSTEM_SM_CECO_COSMOZ_Request_Struct = (ST_883584831b34399a326748c4b1ce95c9Structure)this.ssSTEM_SM_CECO_COSMOZ_Request_Struct.Duplicate();
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
if (head == "em_sm_ceco_cosmoz_request_struct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_SM_CECO_COSMOZ_Request_Struct")) variable.Value = ssSTEM_SM_CECO_COSMOZ_Request_Struct; else variable.Optimized = true;
variable.SetFieldName("em_sm_ceco_cosmoz_request_struct");
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
if (key == IdEM_SM_CECO_COSMOZ_Request_Struct) {
return ssSTEM_SM_CECO_COSMOZ_Request_Struct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_SM_CECO_COSMOZ_Request_Struct.Key.AsGuid) {
return ssSTEM_SM_CECO_COSMOZ_Request_Struct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEM_SM_CECO_COSMOZ_Request_Struct.FillFromOther((IRecord) other.AttributeGet(IdEM_SM_CECO_COSMOZ_Request_Struct));
}
} // RC_d41fc9ae6fb400f4fec40304f5250129
/// <summary>
/// RecordList type <code>EM_SM_CECO_COSMOZ_Request_StructRecordList</code> that represents a record
///  list of <code>EM_SM_CECO_COSMOZ_Request_Struct</code>
/// </summary>
public partial class RL_e20760dd1d848cb0cda3e0447d50e6fc : GenericRecordList<RC_d41fc9ae6fb400f4fec40304f5250129>, IEnumerable, IEnumerator {

protected override RC_d41fc9ae6fb400f4fec40304f5250129 GetElementDefaultValue() {
return new RC_d41fc9ae6fb400f4fec40304f5250129();
}

public T[] ToArray<T>(Func<RC_d41fc9ae6fb400f4fec40304f5250129, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e20760dd1d848cb0cda3e0447d50e6fc recordList, Func<RC_d41fc9ae6fb400f4fec40304f5250129, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e20760dd1d848cb0cda3e0447d50e6fc(RC_d41fc9ae6fb400f4fec40304f5250129[] array) {
  RL_e20760dd1d848cb0cda3e0447d50e6fc result = new RL_e20760dd1d848cb0cda3e0447d50e6fc();
result.InnerFromArray(array);
    return result;
}

public static RL_e20760dd1d848cb0cda3e0447d50e6fc ToList<T>(T[] array, Func <T, RC_d41fc9ae6fb400f4fec40304f5250129> converter) {
  RL_e20760dd1d848cb0cda3e0447d50e6fc result = new RL_e20760dd1d848cb0cda3e0447d50e6fc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e20760dd1d848cb0cda3e0447d50e6fc FromRestList<T>(RestList<T> restList, Func <T, RC_d41fc9ae6fb400f4fec40304f5250129> converter) {
  RL_e20760dd1d848cb0cda3e0447d50e6fc result = new RL_e20760dd1d848cb0cda3e0447d50e6fc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e20760dd1d848cb0cda3e0447d50e6fc() : base() {
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
protected override OSList<RC_d41fc9ae6fb400f4fec40304f5250129> NewList() {
return new RL_e20760dd1d848cb0cda3e0447d50e6fc();
}


} // RL_e20760dd1d848cb0cda3e0447d50e6fc
}

