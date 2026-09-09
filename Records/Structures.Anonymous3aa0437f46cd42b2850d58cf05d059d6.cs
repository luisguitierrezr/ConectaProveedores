namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (f0OgOs1GskKFDVjPBdBZ1g)
///  <code>RC_c7df2d0e3d19438989bc28bf5440baf5</code> that represent
/// s <code>OrderRequestFileApprovalOrderRequestFileApprovalLevelOrderRequestFileOrderMainRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: OrderRequestFileApprovalOrderRequestFileApprovalLevelOrderRequestFileOrderMainRecord
public partial struct RC_c7df2d0e3d19438989bc28bf5440baf5 : ITypedRecord<RC_c7df2d0e3d19438989bc28bf5440baf5> {
internal static readonly GlobalObjectKey IdOrderRequestFileApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*igvHZHI_KNE_GKPaj46z1Q");
internal static readonly GlobalObjectKey IdOrderRequestFileApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*CgSm2lumwlVXTmpOl2dmzg");
internal static readonly GlobalObjectKey IdOrderRequestFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bBLYcy5yTSvWYtqyvxpy0Q");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");

public EN_1710c672f4d7138b664ee1411114271eEntityRecord ssENOrderRequestFileApproval;

public EN_80af67ecab8f43d464cc57955285a024EntityRecord ssENOrderRequestFileApprovalLevel;

public EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord ssENOrderRequestFile;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;


public BitArray OptimizedAttributes;

public RC_c7df2d0e3d19438989bc28bf5440baf5() {
OptimizedAttributes = null;
ssENOrderRequestFileApproval = new EN_1710c672f4d7138b664ee1411114271eEntityRecord();
ssENOrderRequestFileApprovalLevel = new EN_80af67ecab8f43d464cc57955285a024EntityRecord();
ssENOrderRequestFile = new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(6,false);
    all[1] = new BitArray(12,false);
    all[2] = new BitArray(17,false);
    all[3] = new BitArray(29,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderRequestFileApproval.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderRequestFileApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderRequestFile.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENOrderRequestFileApproval.OptimizedAttributes = value[0];
    ssENOrderRequestFileApprovalLevel.OptimizedAttributes = value[1];
    ssENOrderRequestFile.OptimizedAttributes = value[2];
    ssENOrderMain.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENOrderRequestFileApproval.OptimizedAttributes;
    all[1] = ssENOrderRequestFileApprovalLevel.OptimizedAttributes;
    all[2] = ssENOrderRequestFile.OptimizedAttributes;
    all[3] = ssENOrderMain.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderRequestFileApproval.Read( r, ref index);
ssENOrderRequestFileApprovalLevel.Read( r, ref index);
ssENOrderRequestFile.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
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
public void ReadIM(RC_c7df2d0e3d19438989bc28bf5440baf5 r) {
this = r;
}


public static bool operator == (RC_c7df2d0e3d19438989bc28bf5440baf5 a, RC_c7df2d0e3d19438989bc28bf5440baf5 b) {
if (a.ssENOrderRequestFileApproval != b.ssENOrderRequestFileApproval) return false;
if (a.ssENOrderRequestFileApprovalLevel != b.ssENOrderRequestFileApprovalLevel) return false;
if (a.ssENOrderRequestFile != b.ssENOrderRequestFile) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
return true;
}

public static bool operator != (RC_c7df2d0e3d19438989bc28bf5440baf5 a, RC_c7df2d0e3d19438989bc28bf5440baf5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c7df2d0e3d19438989bc28bf5440baf5)) return false;
return (this == (RC_c7df2d0e3d19438989bc28bf5440baf5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderRequestFileApproval.GetHashCode()
 ^ ssENOrderRequestFileApprovalLevel.GetHashCode()
 ^ ssENOrderRequestFile.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderRequestFileApproval.RecursiveReset();
ssENOrderRequestFileApprovalLevel.RecursiveReset();
ssENOrderRequestFile.RecursiveReset();
ssENOrderMain.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderRequestFileApproval.InternalRecursiveSave();
ssENOrderRequestFileApprovalLevel.InternalRecursiveSave();
ssENOrderRequestFile.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
}


public RC_c7df2d0e3d19438989bc28bf5440baf5 Duplicate() {
RC_c7df2d0e3d19438989bc28bf5440baf5 t;
t.ssENOrderRequestFileApproval = (EN_1710c672f4d7138b664ee1411114271eEntityRecord)this.ssENOrderRequestFileApproval.Duplicate();
t.ssENOrderRequestFileApprovalLevel = (EN_80af67ecab8f43d464cc57955285a024EntityRecord)this.ssENOrderRequestFileApprovalLevel.Duplicate();
t.ssENOrderRequestFile = (EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord)this.ssENOrderRequestFile.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
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
if (head == "orderrequestfileapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFileApproval")) variable.Value = ssENOrderRequestFileApproval; else variable.Optimized = true;
variable.SetFieldName("orderrequestfileapproval");
} else if (head == "orderrequestfileapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFileApprovalLevel")) variable.Value = ssENOrderRequestFileApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("orderrequestfileapprovallevel");
} else if (head == "orderrequestfile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFile")) variable.Value = ssENOrderRequestFile; else variable.Optimized = true;
variable.SetFieldName("orderrequestfile");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
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
if (key == IdOrderRequestFileApproval) {
return ssENOrderRequestFileApproval;
}
if (key == IdOrderRequestFileApprovalLevel) {
return ssENOrderRequestFileApprovalLevel;
}
if (key == IdOrderRequestFile) {
return ssENOrderRequestFile;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderRequestFileApproval.Key.AsGuid) {
return ssENOrderRequestFileApproval;
}
if (attributeKey == IdOrderRequestFileApprovalLevel.Key.AsGuid) {
return ssENOrderRequestFileApprovalLevel;
}
if (attributeKey == IdOrderRequestFile.Key.AsGuid) {
return ssENOrderRequestFile;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderRequestFileApproval.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFileApproval));
ssENOrderRequestFileApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFileApprovalLevel));
ssENOrderRequestFile.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFile));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
}
} // RC_c7df2d0e3d19438989bc28bf5440baf5
/// <summary>
/// RecordList type
///  <code>OrderRequestFileApprovalOrderRequestFileApprovalLevelOrderRequestFileOrderMainRecordList</cod
/// e> that represents a record list of <code>OrderRequestFileApproval, OrderRequestFileApprovalLevel,
///  OrderRequestFile, OrderMain</code>
/// </summary>
public partial class RL_248cdd7729c13fb50aed8d762c8fa086 : GenericRecordList<RC_c7df2d0e3d19438989bc28bf5440baf5>, IEnumerable, IEnumerator {

protected override RC_c7df2d0e3d19438989bc28bf5440baf5 GetElementDefaultValue() {
return new RC_c7df2d0e3d19438989bc28bf5440baf5();
}

public T[] ToArray<T>(Func<RC_c7df2d0e3d19438989bc28bf5440baf5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_248cdd7729c13fb50aed8d762c8fa086 recordList, Func<RC_c7df2d0e3d19438989bc28bf5440baf5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_248cdd7729c13fb50aed8d762c8fa086(RC_c7df2d0e3d19438989bc28bf5440baf5[] array) {
  RL_248cdd7729c13fb50aed8d762c8fa086 result = new RL_248cdd7729c13fb50aed8d762c8fa086();
result.InnerFromArray(array);
    return result;
}

public static RL_248cdd7729c13fb50aed8d762c8fa086 ToList<T>(T[] array, Func <T, RC_c7df2d0e3d19438989bc28bf5440baf5> converter) {
  RL_248cdd7729c13fb50aed8d762c8fa086 result = new RL_248cdd7729c13fb50aed8d762c8fa086();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_248cdd7729c13fb50aed8d762c8fa086 FromRestList<T>(RestList<T> restList, Func <T, RC_c7df2d0e3d19438989bc28bf5440baf5> converter) {
  RL_248cdd7729c13fb50aed8d762c8fa086 result = new RL_248cdd7729c13fb50aed8d762c8fa086();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_248cdd7729c13fb50aed8d762c8fa086() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(6,false);
def[1] = new BitArray(12,false);
def[2] = new BitArray(17,false);
def[3] = new BitArray(29,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c7df2d0e3d19438989bc28bf5440baf5> NewList() {
return new RL_248cdd7729c13fb50aed8d762c8fa086();
}


} // RL_248cdd7729c13fb50aed8d762c8fa086
}

