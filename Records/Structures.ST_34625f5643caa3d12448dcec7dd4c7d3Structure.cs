namespace ssConectaProveedores {
/// <summary>
/// [Structure] Entra_Workflow_Userlist (4E+lblBa4UimzHRlY0KCHw)
///  <code>ST_34625f5643caa3d12448dcec7dd4c7d3Structure</code> that represent
/// s <code>Entra_Workflow_Userlist</code> <p>Description: </p>
/// </summary>
// Name: Entra_Workflow_Userlist
public partial struct ST_34625f5643caa3d12448dcec7dd4c7d3Structure : ITypedRecord<ST_34625f5643caa3d12448dcec7dd4c7d3Structure> {
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*t3nFGvvfrESf72StkQwCvQ");
internal static readonly GlobalObjectKey IdRole = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*x_LcTHKEF02moEwS7JJeKA");
internal static readonly GlobalObjectKey IdCancelMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*COVbGoxKq0Kn_SntL8n66g");
internal static readonly GlobalObjectKey IdApprovalStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*y9wd2k9ctUS4QwtAYqt_Rw");
internal static readonly GlobalObjectKey IdApproveAsAreaUsuaria = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kFCl8mK+WEmUcB5ek7xmAg");
internal static readonly GlobalObjectKey IdModifyMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Xv+3VX38sEGipy1PNbCYZg");
internal static readonly GlobalObjectKey IdIsNotMapped = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*TGuwRXUVWUe4Ta+Eg+eNCg");
internal static readonly GlobalObjectKey IdIsReassigned = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QxL0TcdIzU+P7NjepoB9lQ");
internal static readonly GlobalObjectKey IdIsSubstitute = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ty7wxGRjMke8d98ay1t8ZQ");

public string ssName;

public string ssRole;

public string ssCancelMessage;

public int ssApprovalStatusId;

public bool ssApproveAsAreaUsuaria;

public string ssModifyMessage;

public bool ssIsNotMapped;

public bool ssIsReassigned;

public bool ssIsSubstitute;


public BitArray OptimizedAttributes;

public ST_34625f5643caa3d12448dcec7dd4c7d3Structure() {
OptimizedAttributes = null;
ssName = "";
ssRole = "";
ssCancelMessage = "";
ssApprovalStatusId = 0;
ssApproveAsAreaUsuaria = false;
ssModifyMessage = "";
ssIsNotMapped = false;
ssIsReassigned = false;
ssIsSubstitute = false;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssName = r.ReadText(index++, "Entra_Workflow_Userlist.Name", "");
ssRole = r.ReadText(index++, "Entra_Workflow_Userlist.Role", "");
ssCancelMessage = r.ReadText(index++, "Entra_Workflow_Userlist.CancelMessage", "");
ssApprovalStatusId = r.ReadEntityReference(index++, "Entra_Workflow_Userlist.ApprovalStatusId", 0);
ssApproveAsAreaUsuaria = r.ReadBoolean(index++, "Entra_Workflow_Userlist.ApproveAsAreaUsuaria", false);
ssModifyMessage = r.ReadText(index++, "Entra_Workflow_Userlist.ModifyMessage", "");
ssIsNotMapped = r.ReadBoolean(index++, "Entra_Workflow_Userlist.IsNotMapped", false);
ssIsReassigned = r.ReadBoolean(index++, "Entra_Workflow_Userlist.IsReassigned", false);
ssIsSubstitute = r.ReadBoolean(index++, "Entra_Workflow_Userlist.IsSubstitute", false);
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
public void ReadIM(ST_34625f5643caa3d12448dcec7dd4c7d3Structure r) {
this = r;
}


public static bool operator == (ST_34625f5643caa3d12448dcec7dd4c7d3Structure a, ST_34625f5643caa3d12448dcec7dd4c7d3Structure b) {
if (a.ssName != b.ssName) return false;
if (a.ssRole != b.ssRole) return false;
if (a.ssCancelMessage != b.ssCancelMessage) return false;
if (a.ssApprovalStatusId != b.ssApprovalStatusId) return false;
if (a.ssApproveAsAreaUsuaria != b.ssApproveAsAreaUsuaria) return false;
if (a.ssModifyMessage != b.ssModifyMessage) return false;
if (a.ssIsNotMapped != b.ssIsNotMapped) return false;
if (a.ssIsReassigned != b.ssIsReassigned) return false;
if (a.ssIsSubstitute != b.ssIsSubstitute) return false;
return true;
}

public static bool operator != (ST_34625f5643caa3d12448dcec7dd4c7d3Structure a, ST_34625f5643caa3d12448dcec7dd4c7d3Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_34625f5643caa3d12448dcec7dd4c7d3Structure)) return false;
return (this == (ST_34625f5643caa3d12448dcec7dd4c7d3Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssRole.GetHashCode()
 ^ ssCancelMessage.GetHashCode()
 ^ ssApprovalStatusId.GetHashCode()
 ^ ssApproveAsAreaUsuaria.GetHashCode()
 ^ ssModifyMessage.GetHashCode()
 ^ ssIsNotMapped.GetHashCode()
 ^ ssIsReassigned.GetHashCode()
 ^ ssIsSubstitute.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_34625f5643caa3d12448dcec7dd4c7d3Structure Duplicate() {
ST_34625f5643caa3d12448dcec7dd4c7d3Structure t;
t.ssName = this.ssName;
t.ssRole = this.ssRole;
t.ssCancelMessage = this.ssCancelMessage;
t.ssApprovalStatusId = this.ssApprovalStatusId;
t.ssApproveAsAreaUsuaria = this.ssApproveAsAreaUsuaria;
t.ssModifyMessage = this.ssModifyMessage;
t.ssIsNotMapped = this.ssIsNotMapped;
t.ssIsReassigned = this.ssIsReassigned;
t.ssIsSubstitute = this.ssIsSubstitute;
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
if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "role") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Role")) variable.Value = ssRole; else variable.Optimized = true;
} else if (head == "cancelmessage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CancelMessage")) variable.Value = ssCancelMessage; else variable.Optimized = true;
} else if (head == "approvalstatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalStatusId")) variable.Value = ssApprovalStatusId; else variable.Optimized = true;
} else if (head == "approveasareausuaria") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApproveAsAreaUsuaria")) variable.Value = ssApproveAsAreaUsuaria; else variable.Optimized = true;
} else if (head == "modifymessage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ModifyMessage")) variable.Value = ssModifyMessage; else variable.Optimized = true;
} else if (head == "isnotmapped") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsNotMapped")) variable.Value = ssIsNotMapped; else variable.Optimized = true;
} else if (head == "isreassigned") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsReassigned")) variable.Value = ssIsReassigned; else variable.Optimized = true;
} else if (head == "issubstitute") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSubstitute")) variable.Value = ssIsSubstitute; else variable.Optimized = true;
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
if (key == IdName) {
return ssName;
}
if (key == IdRole) {
return ssRole;
}
if (key == IdCancelMessage) {
return ssCancelMessage;
}
if (key == IdApprovalStatusId) {
return ssApprovalStatusId;
}
if (key == IdApproveAsAreaUsuaria) {
return ssApproveAsAreaUsuaria;
}
if (key == IdModifyMessage) {
return ssModifyMessage;
}
if (key == IdIsNotMapped) {
return ssIsNotMapped;
}
if (key == IdIsReassigned) {
return ssIsReassigned;
}
if (key == IdIsSubstitute) {
return ssIsSubstitute;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdRole.Key.AsGuid) {
return ssRole;
}
if (attributeKey == IdCancelMessage.Key.AsGuid) {
return ssCancelMessage;
}
if (attributeKey == IdApprovalStatusId.Key.AsGuid) {
return ssApprovalStatusId;
}
if (attributeKey == IdApproveAsAreaUsuaria.Key.AsGuid) {
return ssApproveAsAreaUsuaria;
}
if (attributeKey == IdModifyMessage.Key.AsGuid) {
return ssModifyMessage;
}
if (attributeKey == IdIsNotMapped.Key.AsGuid) {
return ssIsNotMapped;
}
if (attributeKey == IdIsReassigned.Key.AsGuid) {
return ssIsReassigned;
}
if (attributeKey == IdIsSubstitute.Key.AsGuid) {
return ssIsSubstitute;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssName = (string) other.AttributeGet(IdName);
ssRole = (string) other.AttributeGet(IdRole);
ssCancelMessage = (string) other.AttributeGet(IdCancelMessage);
ssApprovalStatusId = (int) other.AttributeGet(IdApprovalStatusId);
ssApproveAsAreaUsuaria = (bool) other.AttributeGet(IdApproveAsAreaUsuaria);
ssModifyMessage = (string) other.AttributeGet(IdModifyMessage);
ssIsNotMapped = (bool) other.AttributeGet(IdIsNotMapped);
ssIsReassigned = (bool) other.AttributeGet(IdIsReassigned);
ssIsSubstitute = (bool) other.AttributeGet(IdIsSubstitute);
}
} // ST_34625f5643caa3d12448dcec7dd4c7d3Structure
/// <summary>
/// RecordList type <code>Entra_Workflow_UserlistList</code> that represents a record list of
///  <code>Entra_Workflow_Userlist</code>
/// </summary>
public partial class RL_4af3045b114dbc57d1481fed5aceb93a : GenericRecordList<ST_34625f5643caa3d12448dcec7dd4c7d3Structure>, IEnumerable, IEnumerator {

protected override ST_34625f5643caa3d12448dcec7dd4c7d3Structure GetElementDefaultValue() {
return new ST_34625f5643caa3d12448dcec7dd4c7d3Structure();
}

public T[] ToArray<T>(Func<ST_34625f5643caa3d12448dcec7dd4c7d3Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4af3045b114dbc57d1481fed5aceb93a recordList, Func<ST_34625f5643caa3d12448dcec7dd4c7d3Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4af3045b114dbc57d1481fed5aceb93a(ST_34625f5643caa3d12448dcec7dd4c7d3Structure[] array) {
  RL_4af3045b114dbc57d1481fed5aceb93a result = new RL_4af3045b114dbc57d1481fed5aceb93a();
result.InnerFromArray(array);
    return result;
}

public static RL_4af3045b114dbc57d1481fed5aceb93a ToList<T>(T[] array, Func <T, ST_34625f5643caa3d12448dcec7dd4c7d3Structure> converter) {
  RL_4af3045b114dbc57d1481fed5aceb93a result = new RL_4af3045b114dbc57d1481fed5aceb93a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4af3045b114dbc57d1481fed5aceb93a FromRestList<T>(RestList<T> restList, Func <T, ST_34625f5643caa3d12448dcec7dd4c7d3Structure> converter) {
  RL_4af3045b114dbc57d1481fed5aceb93a result = new RL_4af3045b114dbc57d1481fed5aceb93a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4af3045b114dbc57d1481fed5aceb93a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_34625f5643caa3d12448dcec7dd4c7d3Structure> NewList() {
return new RL_4af3045b114dbc57d1481fed5aceb93a();
}


} // RL_4af3045b114dbc57d1481fed5aceb93a
}

