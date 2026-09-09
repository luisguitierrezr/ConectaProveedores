namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] EM_COSMOZ_Request_Struct (SR3KZkOeEEqjh2GCz9X2Ng)
///  <code>ST_54b441362fa983751bf9575ed6b668beStructure</code> that represent
/// s <code>EM_COSMOZ_Request_Struct</code> <p>Description: EM_COSMOZ_Request_Struct</p>
/// </summary>
// Name: EM_COSMOZ_Request_Struct
public partial struct ST_54b441362fa983751bf9575ed6b668beStructure : ITypedRecord<ST_54b441362fa983751bf9575ed6b668beStructure> {
internal static readonly GlobalObjectKey IdPI_HEADER = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*_YSx1fa1k0m1rfTqe+grvg");
internal static readonly GlobalObjectKey IdPI_ITEM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*854sa2faQ0G3zMHZA_J0ow");

public ST_1186519ca5bb238ab9fc7126d4696469Structure ssPI_HEADER;

public ST_5f3e5a981bd9e9a45ed03e989538932dStructure ssPI_ITEM;


public BitArray OptimizedAttributes;

public ST_54b441362fa983751bf9575ed6b668beStructure() {
OptimizedAttributes = null;
ssPI_HEADER = new ST_1186519ca5bb238ab9fc7126d4696469Structure();
ssPI_ITEM = new ST_5f3e5a981bd9e9a45ed03e989538932dStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = null;
    all[1] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssPI_HEADER.OptimizedAttributes = value[0];
    ssPI_ITEM.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = null;
    all[1] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
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
public void ReadIM(ST_54b441362fa983751bf9575ed6b668beStructure r) {
this = r;
}


public static bool operator == (ST_54b441362fa983751bf9575ed6b668beStructure a, ST_54b441362fa983751bf9575ed6b668beStructure b) {
if (a.ssPI_HEADER != b.ssPI_HEADER) return false;
if (a.ssPI_ITEM != b.ssPI_ITEM) return false;
return true;
}

public static bool operator != (ST_54b441362fa983751bf9575ed6b668beStructure a, ST_54b441362fa983751bf9575ed6b668beStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_54b441362fa983751bf9575ed6b668beStructure)) return false;
return (this == (ST_54b441362fa983751bf9575ed6b668beStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPI_HEADER.GetHashCode()
 ^ ssPI_ITEM.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssPI_HEADER.RecursiveReset();
ssPI_ITEM.RecursiveReset();
}

public void InternalRecursiveSave() {
ssPI_HEADER.InternalRecursiveSave();
ssPI_ITEM.InternalRecursiveSave();
}


public ST_54b441362fa983751bf9575ed6b668beStructure Duplicate() {
ST_54b441362fa983751bf9575ed6b668beStructure t;
t.ssPI_HEADER = (ST_1186519ca5bb238ab9fc7126d4696469Structure)this.ssPI_HEADER.Duplicate();
t.ssPI_ITEM = (ST_5f3e5a981bd9e9a45ed03e989538932dStructure)this.ssPI_ITEM.Duplicate();
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
if (head == "pi_header") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_HEADER")) variable.Value = ssPI_HEADER; else variable.Optimized = true;
variable.SetFieldName("pi_header");
} else if (head == "pi_item") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM")) variable.Value = ssPI_ITEM; else variable.Optimized = true;
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
if (key == IdPI_HEADER) {
return ssPI_HEADER;
}
if (key == IdPI_ITEM) {
return ssPI_ITEM;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_HEADER.Key.AsGuid) {
return ssPI_HEADER;
}
if (attributeKey == IdPI_ITEM.Key.AsGuid) {
return ssPI_ITEM;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPI_HEADER.FillFromOther((IRecord) other.AttributeGet(IdPI_HEADER));
ssPI_ITEM.FillFromOther((IRecord) other.AttributeGet(IdPI_ITEM));
}
} // ST_54b441362fa983751bf9575ed6b668beStructure
/// <summary>
/// RecordList type <code>EM_COSMOZ_Request_StructList</code> that represents a record list of
///  <code>EM_COSMOZ_Request_Struct</code>
/// </summary>
public partial class RL_ea47492884cd728d30240e0428847602 : GenericRecordList<ST_54b441362fa983751bf9575ed6b668beStructure>, IEnumerable, IEnumerator {

protected override ST_54b441362fa983751bf9575ed6b668beStructure GetElementDefaultValue() {
return new ST_54b441362fa983751bf9575ed6b668beStructure();
}

public T[] ToArray<T>(Func<ST_54b441362fa983751bf9575ed6b668beStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ea47492884cd728d30240e0428847602 recordList, Func<ST_54b441362fa983751bf9575ed6b668beStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ea47492884cd728d30240e0428847602(ST_54b441362fa983751bf9575ed6b668beStructure[] array) {
  RL_ea47492884cd728d30240e0428847602 result = new RL_ea47492884cd728d30240e0428847602();
result.InnerFromArray(array);
    return result;
}

public static RL_ea47492884cd728d30240e0428847602 ToList<T>(T[] array, Func <T, ST_54b441362fa983751bf9575ed6b668beStructure> converter) {
  RL_ea47492884cd728d30240e0428847602 result = new RL_ea47492884cd728d30240e0428847602();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ea47492884cd728d30240e0428847602 FromRestList<T>(RestList<T> restList, Func <T, ST_54b441362fa983751bf9575ed6b668beStructure> converter) {
  RL_ea47492884cd728d30240e0428847602 result = new RL_ea47492884cd728d30240e0428847602();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ea47492884cd728d30240e0428847602() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = null;
def[1] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_54b441362fa983751bf9575ed6b668beStructure> NewList() {
return new RL_ea47492884cd728d30240e0428847602();
}


} // RL_ea47492884cd728d30240e0428847602
}

