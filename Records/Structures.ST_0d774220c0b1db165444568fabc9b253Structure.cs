namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ZMXMIMMF_EM_SM_MO_COSMOZREq (VF2zUdP5vkCmCm5LJGNSRQ)
///  <code>ST_0d774220c0b1db165444568fabc9b253Structure</code> that represent
/// s <code>ZMXMIMMF_EM_SM_MO_COSMOZREq</code> <p>Description: ZMXMIMMF_EM_SM_MO_COSMOZREq</p>
/// </summary>
// Name: ZMXMIMMF_EM_SM_MO_COSMOZREq
public partial struct ST_0d774220c0b1db165444568fabc9b253Structure : ITypedRecord<ST_0d774220c0b1db165444568fabc9b253Structure> {
internal static readonly GlobalObjectKey IdPI_HEADER = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*VWMhyqn2eUOLt6D8o6R67g");
internal static readonly GlobalObjectKey IdPI_ITEM_EM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*5io58I2Kjky5y7G3qcOcDw");
internal static readonly GlobalObjectKey IdPI_ITEM_SM = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*CMx_pzm7rUGsbRchkXOOLA");

public ST_b8bada9441ba6abcbadb418a924fe551Structure ssPI_HEADER;

public RL_d88dcbee53485b990306d5474ef9ead7 ssPI_ITEM_EM;

public RL_669be34b3612e89197059379653d4a04 ssPI_ITEM_SM;


public BitArray OptimizedAttributes;

public ST_0d774220c0b1db165444568fabc9b253Structure() {
OptimizedAttributes = null;
ssPI_HEADER = new ST_b8bada9441ba6abcbadb418a924fe551Structure();
ssPI_ITEM_EM = new RL_d88dcbee53485b990306d5474ef9ead7();
ssPI_ITEM_SM = new RL_669be34b3612e89197059379653d4a04();
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
    ssPI_HEADER.OptimizedAttributes = value[0];
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
public void ReadIM(ST_0d774220c0b1db165444568fabc9b253Structure r) {
this = r;
}


public static bool operator == (ST_0d774220c0b1db165444568fabc9b253Structure a, ST_0d774220c0b1db165444568fabc9b253Structure b) {
if (a.ssPI_HEADER != b.ssPI_HEADER) return false;
if (a.ssPI_ITEM_EM != b.ssPI_ITEM_EM) return false;
if (a.ssPI_ITEM_SM != b.ssPI_ITEM_SM) return false;
return true;
}

public static bool operator != (ST_0d774220c0b1db165444568fabc9b253Structure a, ST_0d774220c0b1db165444568fabc9b253Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_0d774220c0b1db165444568fabc9b253Structure)) return false;
return (this == (ST_0d774220c0b1db165444568fabc9b253Structure)o);
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


public ST_0d774220c0b1db165444568fabc9b253Structure Duplicate() {
ST_0d774220c0b1db165444568fabc9b253Structure t;
t.ssPI_HEADER = (ST_b8bada9441ba6abcbadb418a924fe551Structure)this.ssPI_HEADER.Duplicate();
t.ssPI_ITEM_EM = (RL_d88dcbee53485b990306d5474ef9ead7)this.ssPI_ITEM_EM.Duplicate();
t.ssPI_ITEM_SM = (RL_669be34b3612e89197059379653d4a04)this.ssPI_ITEM_SM.Duplicate();
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
ssPI_ITEM_EM = new RL_d88dcbee53485b990306d5474ef9ead7();
ssPI_ITEM_EM.FillFromOther((IOSList) other.AttributeGet(IdPI_ITEM_EM));
ssPI_ITEM_SM = new RL_669be34b3612e89197059379653d4a04();
ssPI_ITEM_SM.FillFromOther((IOSList) other.AttributeGet(IdPI_ITEM_SM));
}
} // ST_0d774220c0b1db165444568fabc9b253Structure
/// <summary>
/// RecordList type <code>ZMXMIMMF_EM_SM_MO_COSMOZREqList</code> that represents a record list of
///  <code>ZMXMIMMF_EM_SM_MO_COSMOZREq</code>
/// </summary>
public partial class RL_1a0c2dd82df4f0c6bfcc0cf1b2daf5f7 : GenericRecordList<ST_0d774220c0b1db165444568fabc9b253Structure>, IEnumerable, IEnumerator {

protected override ST_0d774220c0b1db165444568fabc9b253Structure GetElementDefaultValue() {
return new ST_0d774220c0b1db165444568fabc9b253Structure();
}

public T[] ToArray<T>(Func<ST_0d774220c0b1db165444568fabc9b253Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1a0c2dd82df4f0c6bfcc0cf1b2daf5f7 recordList, Func<ST_0d774220c0b1db165444568fabc9b253Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1a0c2dd82df4f0c6bfcc0cf1b2daf5f7(ST_0d774220c0b1db165444568fabc9b253Structure[] array) {
  RL_1a0c2dd82df4f0c6bfcc0cf1b2daf5f7 result = new RL_1a0c2dd82df4f0c6bfcc0cf1b2daf5f7();
result.InnerFromArray(array);
    return result;
}

public static RL_1a0c2dd82df4f0c6bfcc0cf1b2daf5f7 ToList<T>(T[] array, Func <T, ST_0d774220c0b1db165444568fabc9b253Structure> converter) {
  RL_1a0c2dd82df4f0c6bfcc0cf1b2daf5f7 result = new RL_1a0c2dd82df4f0c6bfcc0cf1b2daf5f7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1a0c2dd82df4f0c6bfcc0cf1b2daf5f7 FromRestList<T>(RestList<T> restList, Func <T, ST_0d774220c0b1db165444568fabc9b253Structure> converter) {
  RL_1a0c2dd82df4f0c6bfcc0cf1b2daf5f7 result = new RL_1a0c2dd82df4f0c6bfcc0cf1b2daf5f7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1a0c2dd82df4f0c6bfcc0cf1b2daf5f7() : base() {
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
protected override OSList<ST_0d774220c0b1db165444568fabc9b253Structure> NewList() {
return new RL_1a0c2dd82df4f0c6bfcc0cf1b2daf5f7();
}


} // RL_1a0c2dd82df4f0c6bfcc0cf1b2daf5f7
}

