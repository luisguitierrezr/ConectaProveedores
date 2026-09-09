namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] EM_SM_RM_COSMOZ_Request_Struct (lDsy0eVaJ0CJxnoZoCVofw)
///  <code>ST_b38fe38940c72474a8e67442651bc995Structure</code> that represent
/// s <code>EM_SM_RM_COSMOZ_Request_Struct</code> <p>Description: EM_SM_RM_COSMOZ_Request_Struct</p>
/// </summary>
// Name: EM_SM_RM_COSMOZ_Request_Struct
public partial struct ST_b38fe38940c72474a8e67442651bc995Structure : ITypedRecord<ST_b38fe38940c72474a8e67442651bc995Structure> {
internal static readonly GlobalObjectKey IdPI_HEADER = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*5O0GU5Z+LkagBJVEPuVKjA");
internal static readonly GlobalObjectKey IdPI_ITEM_EM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*SAuH5to5FkyWpFAMU_Bbgg");
internal static readonly GlobalObjectKey IdPI_ITEM_SM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*FZFWplsaQUKAHnnFx9eWrg");

public ST_cab398c7a09085084636430b80f5aa0dStructure ssPI_HEADER;

public ST_9689a124a3af07dbe86be1015d9b7bb1Structure ssPI_ITEM_EM;

public ST_145adfa176456c38d3985aa98c524483Structure ssPI_ITEM_SM;


public BitArray OptimizedAttributes;

public ST_b38fe38940c72474a8e67442651bc995Structure() {
OptimizedAttributes = null;
ssPI_HEADER = new ST_cab398c7a09085084636430b80f5aa0dStructure();
ssPI_ITEM_EM = new ST_9689a124a3af07dbe86be1015d9b7bb1Structure();
ssPI_ITEM_SM = new ST_145adfa176456c38d3985aa98c524483Structure();
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
public void ReadIM(ST_b38fe38940c72474a8e67442651bc995Structure r) {
this = r;
}


public static bool operator == (ST_b38fe38940c72474a8e67442651bc995Structure a, ST_b38fe38940c72474a8e67442651bc995Structure b) {
if (a.ssPI_HEADER != b.ssPI_HEADER) return false;
if (a.ssPI_ITEM_EM != b.ssPI_ITEM_EM) return false;
if (a.ssPI_ITEM_SM != b.ssPI_ITEM_SM) return false;
return true;
}

public static bool operator != (ST_b38fe38940c72474a8e67442651bc995Structure a, ST_b38fe38940c72474a8e67442651bc995Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b38fe38940c72474a8e67442651bc995Structure)) return false;
return (this == (ST_b38fe38940c72474a8e67442651bc995Structure)o);
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


public ST_b38fe38940c72474a8e67442651bc995Structure Duplicate() {
ST_b38fe38940c72474a8e67442651bc995Structure t;
t.ssPI_HEADER = (ST_cab398c7a09085084636430b80f5aa0dStructure)this.ssPI_HEADER.Duplicate();
t.ssPI_ITEM_EM = (ST_9689a124a3af07dbe86be1015d9b7bb1Structure)this.ssPI_ITEM_EM.Duplicate();
t.ssPI_ITEM_SM = (ST_145adfa176456c38d3985aa98c524483Structure)this.ssPI_ITEM_SM.Duplicate();
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
} // ST_b38fe38940c72474a8e67442651bc995Structure
/// <summary>
/// RecordList type <code>EM_SM_RM_COSMOZ_Request_StructList</code> that represents a record list of
///  <code>EM_SM_RM_COSMOZ_Request_Struct</code>
/// </summary>
public partial class RL_dd20bd82c820364fd7942ec2fae3dda1 : GenericRecordList<ST_b38fe38940c72474a8e67442651bc995Structure>, IEnumerable, IEnumerator {

protected override ST_b38fe38940c72474a8e67442651bc995Structure GetElementDefaultValue() {
return new ST_b38fe38940c72474a8e67442651bc995Structure();
}

public T[] ToArray<T>(Func<ST_b38fe38940c72474a8e67442651bc995Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_dd20bd82c820364fd7942ec2fae3dda1 recordList, Func<ST_b38fe38940c72474a8e67442651bc995Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_dd20bd82c820364fd7942ec2fae3dda1(ST_b38fe38940c72474a8e67442651bc995Structure[] array) {
  RL_dd20bd82c820364fd7942ec2fae3dda1 result = new RL_dd20bd82c820364fd7942ec2fae3dda1();
result.InnerFromArray(array);
    return result;
}

public static RL_dd20bd82c820364fd7942ec2fae3dda1 ToList<T>(T[] array, Func <T, ST_b38fe38940c72474a8e67442651bc995Structure> converter) {
  RL_dd20bd82c820364fd7942ec2fae3dda1 result = new RL_dd20bd82c820364fd7942ec2fae3dda1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_dd20bd82c820364fd7942ec2fae3dda1 FromRestList<T>(RestList<T> restList, Func <T, ST_b38fe38940c72474a8e67442651bc995Structure> converter) {
  RL_dd20bd82c820364fd7942ec2fae3dda1 result = new RL_dd20bd82c820364fd7942ec2fae3dda1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_dd20bd82c820364fd7942ec2fae3dda1() : base() {
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
protected override OSList<ST_b38fe38940c72474a8e67442651bc995Structure> NewList() {
return new RL_dd20bd82c820364fd7942ec2fae3dda1();
}


} // RL_dd20bd82c820364fd7942ec2fae3dda1
}

