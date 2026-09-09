namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] EM_SM_CECO_COSMOZ_Request_Struct (RjyjxLZRmkqLmyX_zD838w)
///  <code>ST_883584831b34399a326748c4b1ce95c9Structure</code> that represent
/// s <code>EM_SM_CECO_COSMOZ_Request_Struct</code> <p>Description:
///  EM_SM_CECO_COSMOZ_Request_Struct</p>
/// </summary>
// Name: EM_SM_CECO_COSMOZ_Request_Struct
public partial struct ST_883584831b34399a326748c4b1ce95c9Structure : ITypedRecord<ST_883584831b34399a326748c4b1ce95c9Structure> {
internal static readonly GlobalObjectKey IdPI_HEADER = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*Fi4bd9jGakW9HkOVVhIYfA");
internal static readonly GlobalObjectKey IdPI_ITEM_EM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*B9SgDP+eIkmhQdviLzvOOw");
internal static readonly GlobalObjectKey IdPI_ITEM_SM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*ZP5n35byNE+_K1g8de3mkA");

public ST_b76a29481a19f994f96cb0bc4134fe6dStructure ssPI_HEADER;

public ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure ssPI_ITEM_EM;

public ST_1241dbde99de907a27732884f6e65ab4Structure ssPI_ITEM_SM;


public BitArray OptimizedAttributes;

public ST_883584831b34399a326748c4b1ce95c9Structure() {
OptimizedAttributes = null;
ssPI_HEADER = new ST_b76a29481a19f994f96cb0bc4134fe6dStructure();
ssPI_ITEM_EM = new ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure();
ssPI_ITEM_SM = new ST_1241dbde99de907a27732884f6e65ab4Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = null;
    all[1] = null;
    all[2] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssPI_HEADER.OptimizedAttributes = value[0];
    ssPI_ITEM_EM.OptimizedAttributes = value[1];
    ssPI_ITEM_SM.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = null;
    all[1] = null;
    all[2] = null;
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
public void ReadIM(ST_883584831b34399a326748c4b1ce95c9Structure r) {
this = r;
}


public static bool operator == (ST_883584831b34399a326748c4b1ce95c9Structure a, ST_883584831b34399a326748c4b1ce95c9Structure b) {
if (a.ssPI_HEADER != b.ssPI_HEADER) return false;
if (a.ssPI_ITEM_EM != b.ssPI_ITEM_EM) return false;
if (a.ssPI_ITEM_SM != b.ssPI_ITEM_SM) return false;
return true;
}

public static bool operator != (ST_883584831b34399a326748c4b1ce95c9Structure a, ST_883584831b34399a326748c4b1ce95c9Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_883584831b34399a326748c4b1ce95c9Structure)) return false;
return (this == (ST_883584831b34399a326748c4b1ce95c9Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPI_HEADER.GetHashCode()
 ^ ssPI_ITEM_EM.GetHashCode()
 ^ ssPI_ITEM_SM.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssPI_HEADER.RecursiveReset();
ssPI_ITEM_EM.RecursiveReset();
ssPI_ITEM_SM.RecursiveReset();
}

public void InternalRecursiveSave() {
ssPI_HEADER.InternalRecursiveSave();
ssPI_ITEM_EM.InternalRecursiveSave();
ssPI_ITEM_SM.InternalRecursiveSave();
}


public ST_883584831b34399a326748c4b1ce95c9Structure Duplicate() {
ST_883584831b34399a326748c4b1ce95c9Structure t;
t.ssPI_HEADER = (ST_b76a29481a19f994f96cb0bc4134fe6dStructure)this.ssPI_HEADER.Duplicate();
t.ssPI_ITEM_EM = (ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure)this.ssPI_ITEM_EM.Duplicate();
t.ssPI_ITEM_SM = (ST_1241dbde99de907a27732884f6e65ab4Structure)this.ssPI_ITEM_SM.Duplicate();
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
} else if (head == "pi_item_em") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM_EM")) variable.Value = ssPI_ITEM_EM; else variable.Optimized = true;
variable.SetFieldName("pi_item_em");
} else if (head == "pi_item_sm") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PI_ITEM_SM")) variable.Value = ssPI_ITEM_SM; else variable.Optimized = true;
variable.SetFieldName("pi_item_sm");
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
if (key == IdPI_ITEM_EM) {
return ssPI_ITEM_EM;
}
if (key == IdPI_ITEM_SM) {
return ssPI_ITEM_SM;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPI_HEADER.Key.AsGuid) {
return ssPI_HEADER;
}
if (attributeKey == IdPI_ITEM_EM.Key.AsGuid) {
return ssPI_ITEM_EM;
}
if (attributeKey == IdPI_ITEM_SM.Key.AsGuid) {
return ssPI_ITEM_SM;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPI_HEADER.FillFromOther((IRecord) other.AttributeGet(IdPI_HEADER));
ssPI_ITEM_EM.FillFromOther((IRecord) other.AttributeGet(IdPI_ITEM_EM));
ssPI_ITEM_SM.FillFromOther((IRecord) other.AttributeGet(IdPI_ITEM_SM));
}
} // ST_883584831b34399a326748c4b1ce95c9Structure
/// <summary>
/// RecordList type <code>EM_SM_CECO_COSMOZ_Request_StructList</code> that represents a record list of
///  <code>EM_SM_CECO_COSMOZ_Request_Struct</code>
/// </summary>
public partial class RL_ec926d62c26ddea3460621117c996902 : GenericRecordList<ST_883584831b34399a326748c4b1ce95c9Structure>, IEnumerable, IEnumerator {

protected override ST_883584831b34399a326748c4b1ce95c9Structure GetElementDefaultValue() {
return new ST_883584831b34399a326748c4b1ce95c9Structure();
}

public T[] ToArray<T>(Func<ST_883584831b34399a326748c4b1ce95c9Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ec926d62c26ddea3460621117c996902 recordList, Func<ST_883584831b34399a326748c4b1ce95c9Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ec926d62c26ddea3460621117c996902(ST_883584831b34399a326748c4b1ce95c9Structure[] array) {
  RL_ec926d62c26ddea3460621117c996902 result = new RL_ec926d62c26ddea3460621117c996902();
result.InnerFromArray(array);
    return result;
}

public static RL_ec926d62c26ddea3460621117c996902 ToList<T>(T[] array, Func <T, ST_883584831b34399a326748c4b1ce95c9Structure> converter) {
  RL_ec926d62c26ddea3460621117c996902 result = new RL_ec926d62c26ddea3460621117c996902();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ec926d62c26ddea3460621117c996902 FromRestList<T>(RestList<T> restList, Func <T, ST_883584831b34399a326748c4b1ce95c9Structure> converter) {
  RL_ec926d62c26ddea3460621117c996902 result = new RL_ec926d62c26ddea3460621117c996902();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ec926d62c26ddea3460621117c996902() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = null;
def[1] = null;
def[2] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_883584831b34399a326748c4b1ce95c9Structure> NewList() {
return new RL_ec926d62c26ddea3460621117c996902();
}


} // RL_ec926d62c26ddea3460621117c996902
}

